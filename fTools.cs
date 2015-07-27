using CodeImp.DoomBuilder;
using CodeImp.DoomBuilder.Geometry;
using CodeImp.DoomBuilder.Map;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TriDelta.PathTools {
   public partial class fTools : Form {
      BuilderPlug plug;
      PathNodes nodes;

      public fTools(BuilderPlug p) {
         InitializeComponent();

         nodes = new PathNodes();
         nodes.NodesChanged += nodes_NodesChanged;
         plug = p;
         plug.MapDataChanged += plug_MapDataChanged;

         PopulatePathList();
      }

      private void PopulatePathList() {
         lstPathPoints.Items.Clear();
         foreach (PathNode node in nodes) {
            if (node.Next != null)
               lstPathPoints.Items.Add(node);
         }

         if (lstPathPoints.Items.Count > 0)
            lstPathPoints.SelectedIndex = 0;
      }

      private void nodes_NodesChanged() {
         PopulatePathList();
      }

      private void plug_MapDataChanged() {
         nodes.Update();
      }

      private void cmdAdjustSpeed_Click(object sender, EventArgs e) {
         int unit, amount;

         if (lstPathPoints.SelectedItem == null) {
            MessageBox.Show("You must select an interpolation point first.");
            return;
         }
         PathNode current = (PathNode)lstPathPoints.SelectedItem;

         if (!int.TryParse(txtUnitLength.Text, out unit))
            return;
         if (!int.TryParse(txtUnitTime.Text, out amount))
            return;


         float ticsperunit = (float)amount / (float)unit;

         General.Map.UndoRedo.CreateUndo("Adjust path travel time");
         List<PathNode> path = new List<PathNode>();
         do {
            if (current.Next != null) {
               float length = (current.Position - current.Next.Position).GetLength();
               current.TravelTime = (int)Math.Round(length * ticsperunit);
               if (current.TravelTime < 1)
                  current.TravelTime = 1;

               path.Add(current);
            }
            current = current.Next;
         } while (current != null && !path.Contains(current));

         General.Interface.DisplayStatus(CodeImp.DoomBuilder.Windows.StatusType.Action, path.Count + " points in the path were adjusted to " + ticsperunit + " octtics for every one unit");
      }


      private List<PathNode> GetPath(PathNode Start) {
         List<PathNode> path = new List<PathNode>();

         PathNode current = Start;
         while (current != null && !path.Contains(current)) {
            path.Add(current);
            current = current.Next;
         }
         return path;
      }

      private void cmdAdjustAngle_Click(object sender, EventArgs e) {
         if (lstPathPoints.SelectedItem == null) {
            MessageBox.Show("You must select an interpolation point first.");
            return;
         }

         List<PathNode> path = GetPath((PathNode)lstPathPoints.SelectedItem);
         if (path.Count > 1) {
            PathNode startnode = path[0];
            PathNode endnode = path[path.Count - 1];
            PathNode last = endnode.Next == startnode ? endnode : null;
            Vector3D p1, p2, delta;

            General.Map.UndoRedo.CreateUndo("Adjust path angles");
            foreach (PathNode current in path) {
               if (last == null) {
                  p1 = current.Position;
               } else {
                  p1 = last.Position;
               }

               if (current.Next != null) {
                  p2 = current.Next.Position;
               } else {
                  p2 = current.Position;
               }

               delta = p2 - p1;

               if (chkAdjustAngle.Checked)
                  current.Rotate(delta.GetAngleXY());

               if (chkAdjustPitch.Checked) {
                  float zangle = Angle2D.RadToDeg(delta.GetAngleZ()) - 180;
                  current.Thing.SetPitch((int)zangle);
               }

               last = current;
            }
            General.Map.IsChanged = true;
            General.Interface.RedrawDisplay();
            General.Interface.DisplayStatus(CodeImp.DoomBuilder.Windows.StatusType.Action, path.Count + " points in the path were adjusted.");
         } else {
            MessageBox.Show("Path must have at least 2 points.");
         }
      }

      //interpolation functions ripped straight from zdoom
      private float splerp(float t, float p1, float p2, float p3, float p4) {
         float t2 = t;
         float res = 2*p2;
         res += (p3 - p1) * t;
         t2 *= t;
         res += (2*p1 - 5*p2 + 4*p3 - p4) * t2;
         t2 *= t;
         res += (3*p2 - 3*p3 + p4 - p1) * t2;
         return 0.5f * res;
      }

      private float lerp(float t, float p1, float p2) {
	      return p1 + t * (p2 - p1);
      }

      private void cmdCreateThings_Click(object sender, EventArgs e) {
         if (lstPathPoints.SelectedItem == null) {
            MessageBox.Show("You must select an interpolation point first.");
            return;
         }

         List<PathNode> path = GetPath((PathNode)lstPathPoints.SelectedItem);
         if (path.Count > 1) {

            foreach (PathNode n in path)
               n.Thing.DetermineSector();

            int type;
            float interval, angleoffset;

            if (!int.TryParse(txtCreateType.Text, out type))
               return;
            if (!float.TryParse(txtCreateInterval.Text, out interval))
               return;
            if (!float.TryParse(txtAngleOffset.Text, out angleoffset))
               return;

            Vector3D p1, p2, delta;
            float leftover = 0;

            if (rLineTypeLinear.Checked) {
               General.Map.UndoRedo.CreateUndo("Create path things");
               foreach (PathNode current in path) {
                  p1 = current.Position;
                  if (current.Next != null) {
                     p2 = current.Next.Position;
                  } else {
                     p2 = current.Position;
                  }

                  delta = p2 - p1;
                  Vector3D norm = delta.GetNormal();

                  float offset = leftover > 0 ? interval - leftover : 0;
                  float length = delta.GetLength();

                  if (offset <= length) {
                     float seglength = length - offset;
                     int cnt = (int)Math.Floor(seglength / interval) + 1;

                     float newlen = 0;
                     for (int i = 0; i < cnt; i++) {
                        newlen = offset + (interval * i);
                        Vector3D pos = new Vector3D(
                           p1.x + norm.x * newlen,
                           p1.y + norm.y * newlen,
                           p1.z + norm.z * newlen
                        );

                        Thing newthing = General.Map.Map.CreateThing();
                        General.Settings.ApplyDefaultThingSettings(newthing);

                        newthing.Type = type;
                        newthing.Move(pos);
                        newthing.Rotate(delta.GetAngleXY() + Angle2D.DegToRad(angleoffset));

                        if (rApplyZPitch.Checked)
                           newthing.SetPitch((int)Angle2D.RadToDeg(delta.GetAngleZ()));
                        if (rApplyZRoll.Checked)
                           newthing.SetRoll((int)Angle2D.RadToDeg(delta.GetAngleZ()));

                        newthing.UpdateConfiguration();
                     }

                     leftover = seglength % interval;
                  } else {
                     leftover += length;
                  }
               }
            } else {
               if (path.Count < 4) {
                  MessageBox.Show("You must have at least 4 points in spline mode");
                  return;
               }
               General.Map.UndoRedo.CreateUndo("Create path things");

               int i = 1;
               int len = path.Count;
               PathNode last = path[0];
               PathNode current = path[1];
               Vector3D point;               
               float measurestep = 0.2f;
               Thing lastthing = null;

               while (i < len && current.Next != null && current.Next.Next != null) {
                  //Get the approximate length of the arc
                  Vector3D milast = current.Position;
                  float t = 0;
                  float length = 0;

                  while (t <= 1f) {
                     point = new Vector3D(
                        splerp(t, last.Position.x, current.Position.x, current.Next.Position.x, current.Next.Next.Position.x),
                        splerp(t, last.Position.y, current.Position.y, current.Next.Position.y, current.Next.Next.Position.y),
                        splerp(t, last.Position.z, current.Position.z, current.Next.Position.z, current.Next.Next.Position.z)
                     );

                     if (t > 0f) {
                        float seglen = (point - milast).GetLength();
                        length += seglen;
                     }

                     milast = point;
                     t += measurestep;
                  }
                  
                  //plot the points along the arc
                  float offset = leftover > 0 ? interval - leftover : 0;
                  if (offset <= length) {
                     float seglength = length - offset;
                     int cnt = (int)Math.Ceiling(seglength / interval);
                     float newlen = 0;
                     for (int j = 0; j < cnt; j++) {
                        newlen = offset + (interval * j);

                        //position is given in absolute Z, in order to handle varying sector floor heights
                        t = newlen / length;
                        Vector3D pos = new Vector3D(
                           splerp(t, last.Position.x, current.Position.x, current.Next.Position.x, current.Next.Next.Position.x),
                           splerp(t, last.Position.y, current.Position.y, current.Next.Position.y, current.Next.Next.Position.y),
                           splerp(t, last.Position.z, current.Position.z, current.Next.Position.z, current.Next.Next.Position.z)
                        );

                        Thing newthing = General.Map.Map.CreateThing();
                        General.Settings.ApplyDefaultThingSettings(newthing);

                        newthing.Type = type;
                        newthing.Move(pos);

                        //convert absolute z back to sector z
                        newthing.DetermineSector();
                        if (newthing.Sector != null)
                           pos.z -= Sector.GetFloorPlane(newthing.Sector).GetZ(pos);
                        newthing.Move(pos);

                        if (lastthing != null) {
                           delta = newthing.Position - lastthing.Position;
                           newthing.Rotate(delta.GetAngleXY() + Angle2D.DegToRad(angleoffset));
                           if (rApplyZPitch.Checked)
                              newthing.SetPitch((int)Angle2D.RadToDeg(delta.GetAngleZ()));
                           if (rApplyZRoll.Checked)
                              newthing.SetRoll((int)Angle2D.RadToDeg(delta.GetAngleZ()));
                        } else {
                           delta = current.Position - last.Position;
                           newthing.Rotate(delta.GetAngleXY() + Angle2D.DegToRad(angleoffset));
                           if (rApplyZPitch.Checked)
                              newthing.SetPitch((int)Angle2D.RadToDeg(delta.GetAngleZ()));
                           if (rApplyZRoll.Checked)
                              newthing.SetRoll((int)Angle2D.RadToDeg(delta.GetAngleZ()));
                        }
                        newthing.UpdateConfiguration();
                        lastthing = newthing;
                     }

                     leftover = seglength % interval;
                  } else {
                     leftover += length;
                  }

                  i++;
                  last = current;
                  if (i < len)
                     current = path[i];
               }
            }
            General.Map.ThingsFilter.Update();  
            General.Interface.RedrawDisplay();
            General.Interface.DisplayStatus(CodeImp.DoomBuilder.Windows.StatusType.Action, "Create things complete.");
         } else {
            MessageBox.Show("Path must have at least 2 points.");
         }
      }
   }
}
