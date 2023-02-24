namespace CarvedYu
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlHost1 = new DSkin.Controls.ControlHost();
            this.dSkinTabBar1 = new DSkin.Controls.DSkinTabBar();
            this.dSkinTabItem1 = new DSkin.Controls.DSkinTabItem();
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel2 = new DSkin.Controls.DSkinLabel();
            this.dSkinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlHost1
            // 
            this.controlHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHost1.Location = new System.Drawing.Point(54, 40);
            this.controlHost1.Margin = new System.Windows.Forms.Padding(0);
            this.controlHost1.Name = "controlHost1";
            this.controlHost1.Size = new System.Drawing.Size(1302, 699);
            this.controlHost1.TabIndex = 0;
            this.controlHost1.TransparencyKey = System.Drawing.Color.Empty;
            // 
            // dSkinTabBar1
            // 
            this.dSkinTabBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dSkinTabBar1.EnabledLayoutContent = true;
            this.dSkinTabBar1.Items.AddRange(new DSkin.DirectUI.DuiBaseControl[] {
            this.dSkinTabItem1});
            this.dSkinTabBar1.Location = new System.Drawing.Point(4, 40);
            this.dSkinTabBar1.Margin = new System.Windows.Forms.Padding(0);
            this.dSkinTabBar1.Name = "dSkinTabBar1";
            this.dSkinTabBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.dSkinTabBar1.Size = new System.Drawing.Size(50, 699);
            this.dSkinTabBar1.TabIndex = 0;
            // 
            // dSkinTabItem1
            // 
            this.dSkinTabItem1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinTabItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dSkinTabItem1.HoverColor = System.Drawing.Color.Empty;
            this.dSkinTabItem1.Location = new System.Drawing.Point(0, 0);
            this.dSkinTabItem1.Name = "dSkinTabItem1";
            this.dSkinTabItem1.PressColor = System.Drawing.Color.Empty;
            this.dSkinTabItem1.Size = new System.Drawing.Size(50, 100);
            this.dSkinTabItem1.TabPage = null;
            this.dSkinTabItem1.Text = "TAB_PAGE_BAR";
            this.dSkinTabItem1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.dSkinPanel1.Controls.Add(this.dSkinLabel2);
            this.dSkinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dSkinPanel1.Location = new System.Drawing.Point(4, 739);
            this.dSkinPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(1352, 25);
            this.dSkinPanel1.TabIndex = 0;
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.AutoSize = false;
            this.dSkinLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.dSkinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel1.ForeColor = System.Drawing.Color.White;
            this.dSkinLabel1.Location = new System.Drawing.Point(1, 0);
            this.dSkinLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(50, 40);
            this.dSkinLabel1.TabIndex = 1;
            this.dSkinLabel1.Text = "LOGO";
            this.dSkinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dSkinLabel2
            // 
            this.dSkinLabel2.AutoSize = false;
            this.dSkinLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.dSkinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel2.ForeColor = System.Drawing.Color.White;
            this.dSkinLabel2.Location = new System.Drawing.Point(3, 4);
            this.dSkinLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.dSkinLabel2.Name = "dSkinLabel2";
            this.dSkinLabel2.Size = new System.Drawing.Size(50, 20);
            this.dSkinLabel2.TabIndex = 2;
            this.dSkinLabel2.Text = "状态栏";
            this.dSkinLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptionHeight = 40;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.dSkinLabel1);
            this.Controls.Add(this.controlHost1);
            this.Controls.Add(this.dSkinTabBar1);
            this.Controls.Add(this.dSkinPanel1);
            this.DragChangeBackImage = false;
            this.DuiBackgroundRender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.DuiBackgroundRender.RenderBorders = true;
            this.MinimumSize = new System.Drawing.Size(1360, 768);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.SystemButtonsOffset = new System.Drawing.Point(0, 5);
            this.Text = "";
            this.dSkinPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.ControlHost controlHost1;
        private DSkin.Controls.DSkinTabBar dSkinTabBar1;
        private DSkin.Controls.DSkinTabItem dSkinTabItem1;
        private DSkin.Controls.DSkinPanel dSkinPanel1;
        private DSkin.Controls.DSkinLabel dSkinLabel1;
        private DSkin.Controls.DSkinLabel dSkinLabel2;
    }
}

