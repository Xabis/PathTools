using System;
using CodeImp.DoomBuilder.Plugins;
using CodeImp.DoomBuilder.Actions;
using System.Diagnostics;
using CodeImp.DoomBuilder;
using System.Windows.Forms;
using CodeImp.DoomBuilder.Config;
using CodeImp.DoomBuilder.Map;
using System.Collections.Generic;
using CodeImp.DoomBuilder.Geometry;
using CodeImp.DoomBuilder.Editing;

namespace TriDelta.PathTools {
    public delegate void GenericChangedEvent();

    public class BuilderPlug : Plug {
        private ToolStripMenuItem m_mnuTools;
        private fTools m_tools;

        public BuilderPlug() {
            m_mnuTools = new ToolStripMenuItem("Path Tools");
            m_mnuTools.Click += bShowTools_Click;
            m_mnuTools.Enabled = false;
        }

        public override string Name {
            get { return "Path Tools"; }
        }

        public override void OnInitialize() {
            General.Interface.AddMenu(m_mnuTools, CodeImp.DoomBuilder.Windows.MenuSection.ToolsResources);
            base.OnInitialize();
        }

        public override void OnMapOpenEnd() {
            base.OnMapOpenEnd();
            m_mnuTools.Enabled = true;
        }

        public override void OnMapNewEnd() {
            base.OnMapNewEnd();
            m_mnuTools.Enabled = true;
        }

        public override void OnMapCloseEnd() {
            base.OnMapCloseEnd();
            m_mnuTools.Enabled = false;
            if (m_tools != null)
                m_tools.Hide();
        }

        private void bShowTools_Click(object sender, EventArgs e) {
            if (m_tools == null || m_tools.IsDisposed)
                m_tools = new fTools(this);
            m_tools.Show();
        }

        public override void Dispose() {
            base.Dispose();
        }
    }


    public class PathNode {
        private Thing paththing;
        private PathNode m_next = null;

        public PathNode(Thing t) {
            paththing = t;
        }

        public int ID {
            get { return paththing.Tag; }
            set { paththing.Tag = value; }
        }
        public int Index {
            get { return paththing.Index; }
        }

        public Vector3D Position {
            get {
                Vector3D location = paththing.Position;

                if (paththing.Sector == null)
                    paththing.DetermineSector();
                if (paththing.Sector != null)
                    location.z += Sector.GetFloorPlane(paththing.Sector).GetZ(location);
                return location;
            }
        }

        public int TravelTime {
            get { return paththing.Args[1]; }
            set { paththing.Args[1] = value; }
        }

        public Thing Thing {
            get { return paththing; }
        }

        public int NextID {
            get { return paththing.Args[3]; }
            set { paththing.Args[3] = value; }
        }

        public PathNode Next {
            get { return m_next; }
            set { m_next = value; }
        }

        public void Rotate(float newangle) {
            paththing.Rotate(newangle);
        }

        public override string ToString() {
            return "Tag " + ID + " (Thing #" + Index + ")";
        }
    }
}