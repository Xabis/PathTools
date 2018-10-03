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
using CodeImp.DoomBuilder.Windows;

namespace TriDelta.PathTools {
    public partial class fTools : Form {
        public fTools(BuilderPlug p) {
            InitializeComponent();
            txtRetagStart.Text = General.Map.Map.GetNewTag().ToString();
        }

        private List<List<PathNode>> GetSelectedPaths() {
            List<List<PathNode>> paths = new List<List<PathNode>>();

            if (General.Map.Map.SelectedThingsCount > 0) {
                //build deduped list of interpolation things
                Dictionary<int, Thing> nodes = new Dictionary<int, Thing>();
                foreach (Thing t in General.Map.Map.Things) {
                    if (t.Type != 9070)
                        continue;
                    if (nodes.ContainsKey(t.Tag)) //dedupe
                        continue;
                    nodes.Add(t.Tag, t);
                }

                //inspect each selected thing
                foreach (Thing t in General.Map.Map.GetSelectedThings(true)) {
                    //only care about interpolation points
                    if (t.Type != 9070)
                        continue;
                    List<PathNode> path = new List<PathNode>();

                    //switch together list
                    PathNode node = new PathNode(t);
                    while (true) {
                        path.Add(node);
                        if (node.NextID == 0 || !nodes.ContainsKey(node.NextID))
                            break;

                        Thing nt = nodes[node.NextID];
                        PathNode found = null;
                        foreach (PathNode nodecheck in path) {
                            if (nt == nodecheck.Thing) {
                                found = nodecheck;
                                break;
                            }
                        }
                        if (found != null) {
                            node.Next = found;
                            break;
                        }

                        PathNode prevnode = node;
                        node = new PathNode(nt);
                        prevnode.Next = node;
                    }

                    paths.Add(path);
                }
            }
            return paths;
        }

        protected override void OnClosing(CancelEventArgs e) {
            e.Cancel = true;
            base.OnClosing(e);
            this.Hide();
        }

        private void cmdAdjustSpeed_Click(object sender, EventArgs e) {
            int unit, amount;
            bool undocreated = false;

            List<List<PathNode>> paths = GetSelectedPaths();
            if (paths.Count == 0) {
                MessageBox.Show("You must select at least one interpolation point on the map.\n\nEach selected thing will be treated as the start of a new path.");
                return;
            }

            if (!int.TryParse(txtUnitLength.Text, out unit))
                return;
            if (!int.TryParse(txtUnitTime.Text, out amount))
                return;
            float ticsperunit = (float)amount / (float)unit;

            foreach (List<PathNode> path in paths) {
                if (path.Count < 2) {
                    General.WriteLogLine("Selected path starting at id #" + path[0].ID + " must have at least 2 points. Path ignored.");
                    continue;
                }
                if (!undocreated) {
                    undocreated = true;
                    General.Map.UndoRedo.CreateUndo("Adjust path travel time");
                }

                PathNode current = path[0];
                List<PathNode> dupelist = new List<PathNode>();
                do {
                    if (current.Next != null) {
                        float length = (current.Next.Position - current.Position).GetLength();
                        current.TravelTime = (int)Math.Round(length * ticsperunit);
                        if (current.TravelTime < 1)
                            current.TravelTime = 1;

                        dupelist.Add(current);
                    }
                    current = current.Next;
                } while (current != null && !dupelist.Contains(current));
            }

            if (undocreated) {
                General.Map.IsChanged = true;
                General.Map.ThingsFilter.Update();
                General.Interface.DisplayStatus(CodeImp.DoomBuilder.Windows.StatusType.Action, "selected paths were adjusted to " + ticsperunit + " octtics for every one unit");
            } else {
                General.Interface.DisplayStatus(StatusType.Warning, "No applicable paths; aborted.");
            }
        }

        private void cmdAdjustAngle_Click(object sender, EventArgs e) {
            bool undocreated = false;

            List<List<PathNode>> paths = GetSelectedPaths();
            if (paths.Count == 0) {
                MessageBox.Show("You must select at least one interpolation point on the map.\n\nEach selected thing will be treated as the start of a new path.");
                return;
            }


            foreach (List<PathNode> path in paths) {
                if (path.Count < 2) {
                    General.WriteLogLine("Selected path starting at id #" + path[0].ID + " must have at least 2 points. Path ignored.");
                    continue;
                }
                if (!undocreated) {
                    undocreated = true;
                    General.Map.UndoRedo.CreateUndo("Adjust path angles");
                }

                PathNode startnode = path[0];
                PathNode endnode = path[path.Count - 1];
                PathNode last = endnode.Next == startnode ? endnode : null;
                Vector3D p1, p2, delta;

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
            }

            if (undocreated) {
                General.Map.IsChanged = true;
                General.Interface.RedrawDisplay();
                General.Interface.DisplayStatus(CodeImp.DoomBuilder.Windows.StatusType.Action, "selected paths were adjusted.");
            } else {
                General.Interface.DisplayStatus(StatusType.Warning, "No applicable paths; aborted.");
            }
        }

        //interpolation functions ripped straight from zdoom
        private float splerp(float t, float p1, float p2, float p3, float p4) {
            float t2 = t;
            float res = 2*p2;
            res += (p3 - p1) * t;
            t2 *= t;
            res += (2 * p1 - 5 * p2 + 4 * p3 - p4) * t2;
            t2 *= t;
            res += (3 * p2 - 3 * p3 + p4 - p1) * t2;
            return 0.5f * res;
        }

        private float lerp(float t, float p1, float p2) {
            return p1 + t * (p2 - p1);
        }

        private void cmdCreateThings_Click(object sender, EventArgs e) {
            List<List<PathNode>> paths = GetSelectedPaths();
            if (paths.Count == 0) {
                MessageBox.Show("You must select at least one interpolation point on the map.\n\nEach selected thing will be treated as the start of a new path.");
                return;
            }

            int type;
            bool undocreated = false;
            float interval, angleoffset, zoffset;

            if (!int.TryParse(txtCreateType.Text, out type))
                return;
            if (!float.TryParse(txtCreateInterval.Text, out interval))
                return;
            if (!float.TryParse(txtAngleOffset.Text, out angleoffset))
                return;
            if (!float.TryParse(txtZOffset.Text, out zoffset))
                return;

            foreach (List<PathNode> path in paths) {
                if (path.Count < 2) {
                    General.WriteLogLine("Selected path starting at id #" + path[0].ID + " must have at least 2 points. Path ignored.");
                    continue;
                }

                Vector3D p1, p2, delta;
                float leftover = 0;

                if (rLineTypeLinear.Checked) {
                    if (!undocreated) {
                        undocreated = true;
                        General.Map.UndoRedo.CreateUndo("Create path things");
                    }
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
                                newthing.UpdateConfiguration();

                                if (rPlaceMiddle.Checked)
                                    pos.z -= newthing.Height / 2;
                                if (rPlaceTop.Checked)
                                    pos.z -= newthing.Height;
                                pos.z += zoffset;
                                newthing.Move(pos);

                                //convert absolute z back to sector z
                                newthing.DetermineSector();
                                if (newthing.Sector != null)
                                    pos.z -= Sector.GetFloorPlane(newthing.Sector).GetZ(pos);
                                newthing.Move(pos);

                                //apply angle/pitch/roll
                                newthing.Rotate(delta.GetAngleXY() + Angle2D.DegToRad(angleoffset));
                                if (rApplyZPitch.Checked)
                                    newthing.SetPitch((int)Angle2D.RadToDeg(delta.GetAngleZ()));
                                if (rApplyZRoll.Checked)
                                    newthing.SetRoll((int)Angle2D.RadToDeg(delta.GetAngleZ()));
                            }

                            leftover = seglength % interval;
                        } else {
                            leftover += length;
                        }
                    }
                } else {
                    if (path.Count < 4) {
                        General.WriteLogLine("Selected path starting at id #" + path[0].ID + " must have at least 4 points in spline mode. Path ignored.");
                        continue;
                    }
                    if (!undocreated) {
                        undocreated = true;
                        General.Map.UndoRedo.CreateUndo("Create path things");
                    }

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
                                newthing.UpdateConfiguration();

                                if (rPlaceMiddle.Checked)
                                    pos.z -= newthing.Height / 2;
                                if (rPlaceTop.Checked)
                                    pos.z -= newthing.Height;
                                pos.z += zoffset;
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
            }

            if (undocreated) {
                General.Map.ThingsFilter.Update();
                General.Interface.RedrawDisplay();
                General.Interface.DisplayStatus(StatusType.Action, "Create things complete.");
            } else {
                General.Interface.DisplayStatus(StatusType.Warning, "No applicable paths; aborted.");
            }
        }

        private int GetNextUnusedTag(int Start) {
            Dictionary<int, bool> usedtags = new Dictionary<int, bool>();

            foreach (Thing t in General.Map.Map.Things) {
                if (t.Tag > 0 && !usedtags.ContainsKey(t.Tag))
                    usedtags.Add(t.Tag, true);
            }

            for (int i = Start; i <= General.Map.FormatInterface.MaxTag; i++)
                if (!usedtags.ContainsKey(i))
                    return i;
            return 0;
        }

        private void cmdRetag_Click(object sender, EventArgs e) {
            int newtag;

            if (!int.TryParse(txtRetagStart.Text, out newtag)) {
                MessageBox.Show("Invalid tag number");
                return;
            }
            if (newtag <= 0) {
                MessageBox.Show("tag start must be 1 or higher");
                return;
            }

            List<List<PathNode>> paths = GetSelectedPaths();
            if (paths.Count == 0) {
                MessageBox.Show("You must select at least one interpolation point on the map.\n\nIf multiple points are selected, then they will be tagged starting at the end of the previous path's tag range.\n\nSelecting multiple points that share nodes in the path may produce undesired results.");
                return;
            }

            General.Map.UndoRedo.CreateUndo("Retag path");
            foreach (List<PathNode> path in paths) {
                //filter interpolation points for faster lookup during path processing
                List<Thing> ip = new List<Thing>();
                foreach(Thing t in General.Map.Map.Things) {
                    if (t.Type == 9070)
                        ip.Add(t);
                }

                //Retag each node in the path
                foreach(PathNode node in path) {
                    int old = node.ID;
                    newtag = node.ID = GetNextUnusedTag(newtag);

                    //if any ip (anywhere) is pointing to this node, then update it
                    if (old > 0) {
                        foreach(Thing t in ip) {
                            if (t.Args[3] == old)
                                t.Args[3] = newtag;
                        }
                    }
                }
            }

            General.Map.IsChanged = true;
            General.Map.ThingsFilter.Update();
            General.Interface.RedrawDisplay();
            General.Interface.DisplayStatus(CodeImp.DoomBuilder.Windows.StatusType.Action, "Nodes have been retagged.");
        }

        private void cmdSelectThingType_Click(object sender, EventArgs e) {
            int type;
            if (!int.TryParse(txtCreateType.Text, out type))
                return;

            Thing t = General.Map.Map.CreateThing();
            t.Type = type;
            if(General.Interface.ShowEditThings(new List<Thing> { t }) == DialogResult.OK)
                txtCreateType.Text = t.Type.ToString();

            t.Dispose();
        }

        private void cmdCreateEnMasse_Click(object sender, EventArgs e) {
            float scale;
            if (!float.TryParse(txtMassScale.Text, out scale)) {
                MessageBox.Show("Scale must be a decimal number.");
                return;
            }

            //parse list
            List<Vector3D> locations = new List<Vector3D>();
            foreach(string line in txtCoordList.Lines) {
                string[] parts = line.Trim().Split(',');
                if (parts.Length != 3) {
                    MessageBox.Show("Coordinates must be 3 comma-seperated numbers x,y,z");
                    return;
                }
                float x,y,z;
                if (!float.TryParse(parts[0], out x)) {
                    MessageBox.Show("Invalid number " + parts[0]);
                    return;
                }
                if (!float.TryParse(parts[1], out y)) {
                    MessageBox.Show("Invalid number " + parts[1]);
                    return;
                }
                if (!float.TryParse(parts[2], out z)) {
                    MessageBox.Show("Invalid number " + parts[2]);
                    return;
                }
                locations.Add(new Vector3D(x, y, z));
            }

            General.Map.UndoRedo.CreateUndo("Mass create points");
            Thing last = null;
            foreach(Vector3D v in locations) {
                Vector3D pos = v * scale;
                Thing newthing = General.Map.Map.CreateThing();
                General.Settings.ApplyDefaultThingSettings(newthing);
                newthing.Type = 9070;
                newthing.UpdateConfiguration();
                newthing.Move(pos);

                //convert absolute z back to sector z
                newthing.DetermineSector();
                if (newthing.Sector != null)
                    pos.z -= Sector.GetFloorPlane(newthing.Sector).GetZ(pos);
                newthing.Move(pos);

                if (chkMassLinkNodes.Checked) {
                    newthing.Tag = General.Map.Map.GetNewTag();
                    if (last != null)
                        last.Args[3] = newthing.Tag;
                }
                last = newthing;
            }

            General.Map.ThingsFilter.Update();
            General.Interface.RedrawDisplay();
            General.Interface.DisplayStatus(StatusType.Action, "Mass create points complete.");
        }
    }
}
