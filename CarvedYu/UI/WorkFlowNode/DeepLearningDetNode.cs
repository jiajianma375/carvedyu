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
    public class DeepLearningDetNode : CYNodeBase
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            this.Type = DataManager.ModuleType.DeepLearningDetModule;

            Console.WriteLine("create");
            this.ModuleName = "目标检测";
            TypeName = "深度学习-目标检测";

            //this.InputOptions.Add(new STNodeOption("输入", typeof(CYData), false));

           // this.OutputOptions.Add("输出", typeof(CYData), false);
        }
    }
}
