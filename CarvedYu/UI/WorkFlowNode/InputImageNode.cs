using CarvedYu.DataManager;
using CarvedYu.UI.PropertyControl;
using ST.Library.UI.NodeEditor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarvedYu.UI.WorkFlowNode
{
    [STNode("图像输入", "悠然的二货", "776271965@qq.com", "", "")]
    public class InputImageNode : CYNodeBase
    {
        //private PropertyControl.CYNodeCheckBox m_ctrl_checkbox;

        private bool _LocalImage = false;
        [STNodeProperty("本地图片运行", "开启本地图片运行模式,不使用相机")]
        public bool LocalImage
        {
            get { return _LocalImage; }
            set { 
                _LocalImage = value;
                if(value == true)
                {
                    TypeName = "图像输入-本地";
                }
                else
                {
                    TypeName = "图像输入-相机";
                }
            }
        }



        public InputImageNode()
        { //与OnCreate()等效
            //this.Title = "TestNode";
        }


        public override void EditEvent()
        {
            base.EditEvent();
            CYDataSet dataSet = new CYDataSet()
            {
                Name = "测试",
                Description = "",
                SourceID = ModuleID
            };
            if (CYDataSetManager.AddDataSet(dataSet, out string error) == false)
                MessageBox.Show(error);
        }
        protected override void OnCreate()
        {
            base.OnCreate();
            this.Type = DataManager.ModuleType.InputModule;
            //m_ctrl_checkbox = new PropertyControl.CYNodeCheckBox();
            //m_ctrl_checkbox.Text = "Clamp";
            //m_ctrl_checkbox.DisplayRectangle = new Rectangle(10, 40, 120, 20);
            //m_ctrl_checkbox.ValueChanged += (s, e) => this._LocalImage = m_ctrl_checkbox.Checked;
            //this.Controls.Add(m_ctrl_checkbox);

            this.ModuleName = "图像输入";
            if (_LocalImage == true)
            {
                TypeName = "图像输入-本地";
            }
            else
            {
                TypeName = "图像输入-相机";
            }
            //此添加方式会得到添加成功后的 STNodeOption 索引位置
            //int nIndex = this.InputOptions.Add(new STNodeOption("输入", typeof(CYData), false));
            //此添加方式能直接得到一个构建的 STNodeOption
            //STNodeOption op = this.InputOptions.Add("IN_2", typeof(int), true);

            
        }
       
    }
}
