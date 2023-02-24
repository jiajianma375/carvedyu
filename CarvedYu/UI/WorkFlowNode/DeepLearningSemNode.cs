using CarvedYu.DataManager;
using ST.Library.UI.NodeEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvedYu.UI.WorkFlowNode
{
    [STNode("深度学习", "悠然的二货", "776271965@qq.com", "", "")]
    public class DeepLearningSemNode : CYNodeBase
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            this.Type = DataManager.ModuleType.DeepLearningSemModule;

            this.ModuleName = "语义分割";
            TypeName = "深度学习-语义分割";

            //this.OutputNode.TransferData();
            //this.InputOptions.Add(new STNodeOption("输入", typeof(CYData), false));

           // this.OutputOptions.Add("输出", typeof(CYData), false);
        }
    }
}
