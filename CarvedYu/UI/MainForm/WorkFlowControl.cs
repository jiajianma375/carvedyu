using CarvedYu.DataManager;
using CarvedYu.UI.Ex;
using CarvedYu.UI.WorkFlowNode;
using ST.Library.UI.NodeEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarvedYu.UI.MainForm
{
    public partial class WorkFlowControl : DSkin.Controls.DSkinUserControl
    {
        public WorkFlowControl()
        {
            InitializeComponent();
            stNodeTreeView1.LoadAssembly(Application.ExecutablePath);
            stNodeEditor1.LoadAssembly(Application.ExecutablePath);

            stNodeEditor1.ActiveChanged += (s, ea) => stNodePropertyGrid1.SetNode(stNodeEditor1.ActiveNode);
            stNodeEditor1.OptionConnected += (s, ea) => stNodeEditor1.ShowAlert(ea.Status.ToString(), Color.White, ea.Status == ConnectionStatus.Connected ? Color.FromArgb(125, Color.Green) : Color.FromArgb(125, Color.Red));
            stNodeEditor1.CanvasScaled += (s, ea) => stNodeEditor1.ShowAlert("缩放比例: " + stNodeEditor1.CanvasScale.ToString("F2"), Color.White, Color.FromArgb(125, Color.Yellow));
            stNodeEditor1.NodeAdded += (s, ea) => ea.Node.ContextMenuStrip = contextMenuStrip1;

            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Renderer = new ToolStripRendererEx();

            //stNodePropertyGrid1.ShowTitle = false;


            stNodeEditor1.LoadCanvas("TEST");
            stNodeEditor1.NodeAdded += StNodeEditor1_NodeAdded;
        }

        private void StNodeEditor1_NodeAdded(object sender, STNodeEditorEventArgs e)
        {
            CYNodeBase node = e.Node as CYNodeBase;
            if(node == null)
                return;
            var newName = CYModuleManager.GetNewModuleName(node.ModuleName);
            node.ModuleName= newName;

            CYModule module = null;
            switch (node.Type)
            {
                case ModuleType.InputModule:
                    module = new CYInputModule();
                    break;
                case ModuleType.OutputModule:
                    break;
                case ModuleType.DeepLearningSemModule:
                case ModuleType.DeepLearningClsModule:
                case ModuleType.DeepLearningDetModule:
                case ModuleType.DeepLearningInsModule:
                    {
                        module = new CYDeepLearningModule(node.Type);
                    }
                    break;
                case ModuleType.UserScript:
                    break;
                
                case ModuleType.CrossCategoryNms:
                    break;
                default:
                    return;
            }
            module.Name = newName;
            node.ModuleID = module.GetModuleID();
            CYModuleManager.RegisterModule(module, out string error);
            Console.WriteLine("add");
        }

        private void WorkFlowControl_Load(object sender, EventArgs e)
        {
            //stNodeEditor1.Nodes.Add(new LocalImageNode());

            //stNodeEditor1.Nodes.Add(new LocalImageNode());
        }

        private void 移除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stNodeEditor1.ActiveNode == null) return;
            CYNodeBase node = stNodeEditor1.ActiveNode as CYNodeBase;
            if (node != null)
            {
                CYModuleManager.Destroy(node.ModuleID);
            }
            stNodeEditor1.Nodes.Remove(stNodeEditor1.ActiveNode);
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //stNodeEditor1.SaveCanvas("TEST");
            CYNodeBase node = stNodeEditor1.ActiveNode as CYNodeBase;
            if (node != null)
            {
                node.EditEvent();
            }

            
        }

        private void 锁定解锁位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stNodeEditor1.ActiveNode == null) return;
            stNodeEditor1.ActiveNode.LockLocation = !stNodeEditor1.ActiveNode.LockLocation;
        }

        private void 锁定解锁连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stNodeEditor1.ActiveNode.LockOption = !stNodeEditor1.ActiveNode.LockOption;
        }
    }
}
