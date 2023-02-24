using CarvedYu.DataManager;
using DSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvedYu.UI.TemplateControl
{
    public class ProjectTemplate : DSkin.DirectUI.DuiBaseControl
    {
        private DSkin.DirectUI.DuiLabel duiLabel2;
        private DSkin.DirectUI.DuiLabel duiLabel3;
        private DSkin.DirectUI.DuiLabel duiLabel4;
        private DSkin.DirectUI.DuiLabel duiLabel1;

        public string ProjectID { get; set; }
        public ProjectTemplate(string projectID)
        {
            InitializeComponent();
            ProjectID = projectID;
            var tmp = CYProjectManager.GetProject(projectID);
            if (tmp != null)
            {
                duiLabel2.Text = "工程简介:";

                duiLabel3.Text = $"最后修改:{tmp.LastUpdateTime.ToString("yyyy-MM-dd HH:mm:ss")}" ;

                duiLabel4.Text = $"最后运行:{tmp.LastRunTime.ToString("yyyy-MM-dd HH:mm:ss")}";
            }
        }
        private void InitializeComponent()
        {
            this.duiLabel1 = new DSkin.DirectUI.DuiLabel();
            this.duiLabel2 = new DSkin.DirectUI.DuiLabel();
            this.duiLabel3 = new DSkin.DirectUI.DuiLabel();
            this.duiLabel4 = new DSkin.DirectUI.DuiLabel();
            // 
            // duiLabel1
            // 
            this.duiLabel1.AutoEllipsis = true;
            this.duiLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duiLabel1.ForeColor = System.Drawing.Color.White;
            this.duiLabel1.Location = new System.Drawing.Point(0, -1);
            this.duiLabel1.Name = "duiLabel1";
            this.duiLabel1.Size = new System.Drawing.Size(198, 27);
            this.duiLabel1.Text = "名称";
            // 
            // duiLabel2
            // 
            this.duiLabel2.AutoEllipsis = true;
            this.duiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duiLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.duiLabel2.Location = new System.Drawing.Point(1, 24);
            this.duiLabel2.Name = "duiLabel2";
            this.duiLabel2.Size = new System.Drawing.Size(196, 46);
            // 
            // duiLabel3
            // 
            this.duiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duiLabel3.ForeColor = System.Drawing.Color.LightGray;
            this.duiLabel3.Location = new System.Drawing.Point(3, 73);
            this.duiLabel3.Name = "duiLabel3";
            this.duiLabel3.Size = new System.Drawing.Size(195, 17);
            this.duiLabel3.Text = "最后修改:";
            // 
            // duiLabel4
            // 
            this.duiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duiLabel4.ForeColor = System.Drawing.Color.LightGray;
            this.duiLabel4.Location = new System.Drawing.Point(3, 94);
            this.duiLabel4.Name = "duiLabel4";
            this.duiLabel4.Size = new System.Drawing.Size(195, 16);
            this.duiLabel4.Text = "最后运行:";
            // 
            // ProjectTemplate
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundRender.RenderBorders = true;
            this.Controls.Add(this.duiLabel1);
            this.Controls.Add(this.duiLabel2);
            this.Controls.Add(this.duiLabel3);
            this.Controls.Add(this.duiLabel4);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Size = new System.Drawing.Size(230, 120);

        }
    }
}
