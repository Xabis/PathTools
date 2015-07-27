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
    
    public class BuilderPlug : Plug
    {
        private ToolStripMenuItem m_mnuTools;
        private fTools m_tools;
        public event GenericChangedEvent MapDataChanged;

        public BuilderPlug()
        {
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

        public override void OnMapOpenEnd()
        {
            base.OnMapOpenEnd();
            m_mnuTools.Enabled = true;

            if (MapDataChanged != null)
                MapDataChanged();
        }

        public override void OnMapCloseEnd()
        {
            base.OnMapCloseEnd();
            m_mnuTools.Enabled = false;
            if (m_tools != null)
               m_tools.Hide();
        }

        // Geometry pasted
        public override void OnPasteEnd(PasteOptions options)
        {
            if (MapDataChanged != null)
                MapDataChanged();
        }

        // Redo performed
        public override void OnRedoEnd()
        {
            if (MapDataChanged != null)
                MapDataChanged();
        }

        // Undo performed
        public override void OnUndoEnd()
        {
            if (MapDataChanged != null)
                MapDataChanged();
        }

        // Undo created
        public override void OnUndoCreated()
        {
            string desc = General.Map.UndoRedo.NextUndo.Description;
            if (desc == "Edit thing" || desc == "Insert thing")
            {
                if (MapDataChanged != null)
                    MapDataChanged();
            }
        }

        // Undo withdrawn
        public override void OnUndoWithdrawn()
        {
            if (MapDataChanged != null)
                MapDataChanged();
        }

        public override void OnActionEnd(CodeImp.DoomBuilder.Actions.Action action)
        {
            if (action.Name == "builder_deleteitem")
            {
                if (MapDataChanged != null)
                    MapDataChanged();
            }
        }

        private void bShowTools_Click(object sender, EventArgs e)
        {
            if (m_tools == null || m_tools.IsDisposed)
                m_tools = new fTools(this);
            m_tools.Show();
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }


    public class PathNode
    {
        private Thing paththing;
        private PathNode m_next = null;

        public PathNode(Thing t)
        {
            paththing = t;
        }

        public int ID
        {
            get { return paththing.Tag; }
        }
        public int Index
        {
            get { return paththing.Index; }
        }

        public Vector3D Position
        {
            get {

               Vector3D location = paththing.Position;
               if (paththing.Sector != null)
                  location.z += Sector.GetFloorPlane(paththing.Sector).GetZ(location);
               return location;
            }
        }

        public int TravelTime
        {
            get { return paththing.Args[1]; }
            set { paththing.Args[1] = value; }
        }

        public Thing Thing
        {
            get { return paththing; }
        }

        public int NextID
        {
            get { return paththing.Args[3]; }
        }

        public PathNode Next
        {
            get { return m_next; }
            set { m_next = value; }
        }

        public void Rotate(float newangle) {
            paththing.Rotate(newangle);
        }

        public override string ToString()
        {
            return "Tag " + ID + " (Thing #" + Index + ")";
        }
    }

    public class PathNodes : IEnumerable<PathNode>
    {
        public event GenericChangedEvent NodesChanged;

        Dictionary<int, PathNode> dic;

        public PathNodes()
        {
            dic = new Dictionary<int, PathNode>();
            Update();
        }

        public void Update()
        {
            dic.Clear();

            foreach (Thing t in General.Map.Map.Things)
            {
                if (t.Type == 9070) {
                    if (dic.ContainsKey(t.Tag))
                        return;
                    dic.Add(t.Tag, new PathNode(t));
                }
            }

            foreach (KeyValuePair<int, PathNode> pair in dic) {
                if (pair.Value.NextID > 0 && dic.ContainsKey(pair.Value.NextID))
                    pair.Value.Next = dic[pair.Value.NextID];
            }

            if (NodesChanged != null)
                NodesChanged();
        }

        public PathNode GetNodeByIndex(int index)
        {
            foreach (KeyValuePair<int, PathNode> pair in dic)
            {
                if (pair.Value.Index == index)
                    return pair.Value;
            }
            return null;
        }

        public IEnumerator<PathNode> GetEnumerator()
        {
            return dic.Values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return dic.Values.GetEnumerator();
        }
    }
}