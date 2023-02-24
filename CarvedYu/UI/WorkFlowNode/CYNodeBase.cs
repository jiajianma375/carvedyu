using CarvedYu.DataManager;
using ST.Library.UI.NodeEditor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvedYu.UI.WorkFlowNode
{
    public class CYNodeBase : STNode
    {
        [STNodeProperty("Name", "该模块的名称")]
        public string ModuleName { get => this.Title; 
            set { 
                this.Title = value; 
            } }

        /// <summary>
        /// 对应的模块ID
        /// </summary>
        [STNodeProperty("ID", "该模块的ID")]
        public string ModuleID { get;  set; }

        /// <summary>
        /// 模块类型
        /// </summary>
        public ModuleType Type { get; protected set; }

        /// <summary>
        /// 模块的类型文本
        /// </summary>
        protected string TypeName { get; set; } = "基础模块";

        /// <summary>
        /// 默认的输出节点
        /// </summary>
        protected STNodeOption OutputNode;
        /// <summary>
        /// 默认的输入节点
        /// </summary>
        protected STNodeOption InputNode;

        /// <summary>
        /// 当菜单选择编辑时每个子类对应的操作
        /// </summary>
        public virtual void EditEvent()
        {

        }

        protected override void OnCreate()
        {
            base.OnCreate();
            //需要先设置AutoSize=false 才能设置STNode大小
            this.AutoSize = false;
            this.Size = new System.Drawing.Size(150, 80);
            this.Font = new Font("微软雅黑", 10);

            //var ctrl = new STNodeControl();
            //ctrl.Text = "Button";
            //ctrl.Location = new System.Drawing.Point(10, 10);
            //this.Controls.Add(ctrl);
            //this.Title = "TestNode";
            ////此添加方式会得到添加成功后的 STNodeOption 索引位置
            //int nIndex = this.InputOptions.Add(new STNodeOption("IN_1", typeof(string), false));
            ////此添加方式能直接得到一个构建的 STNodeOption
            //STNodeOption op = this.InputOptions.Add("IN_2", typeof(int), true);

            //this.OutputOptions.Add("OUT", typeof(string), false);

            OutputNode = this.OutputOptions.Add("输出", typeof(CYData), false);
            InputNode = this.InputOptions.Add("输入", typeof(CYData), false);

            //InputNode.DataTransfer += new STNodeOptionEventHandler(m_op_in_DataTransfer);
        }

        protected override void OnDrawBody(DrawingTools dt)
        {
            base.OnDrawBody(dt);
            Graphics g = dt.Graphics;
            Brush brush = new SolidBrush(Color.FromArgb(222, 222, 222));
            Font font = new Font("微软雅黑", 8);
            g.DrawString(TypeName, font, brush, new PointF(this.Left + 10, this.Top + 40));

            string time = "0ms";
            SizeF size = g.MeasureString(time, font);
            g.DrawString(time, font, new SolidBrush(Color.LightGreen), new PointF(this.Right - size.Width - 10,this.Bottom - size.Height - 5));
        }

        //当所属容器发生变化时候发生 应当向容器提交自己数据类型期望显示的颜色
        protected override void OnOwnerChanged()
        {
            base.OnOwnerChanged();
            if (this.Owner == null) return;
            this.Owner.SetTypeColor(typeof(CYData), Color.Yellow);
            //此添加方式 会替换容器中已有的类型颜色信息
            this.Owner.SetTypeColor(typeof(int), Color.DodgerBlue, true);
        }
    }
}
