namespace CarvedYu.UI.MainForm
{
    partial class WorkFlowControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkFlowControl));
            this.stNodeEditor1 = new ST.Library.UI.NodeEditor.STNodeEditor();
            this.stNodeTreeView1 = new ST.Library.UI.NodeEditor.STNodeTreeView();
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.stNodePropertyGrid1 = new ST.Library.UI.NodeEditor.STNodePropertyGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锁定解锁位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锁定解锁连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSkinPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stNodeEditor1
            // 
            this.stNodeEditor1.AllowDrop = true;
            this.stNodeEditor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.stNodeEditor1.Curvature = 0.3F;
            this.stNodeEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stNodeEditor1.Location = new System.Drawing.Point(248, 0);
            this.stNodeEditor1.LocationBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stNodeEditor1.MarkBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stNodeEditor1.MarkForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stNodeEditor1.MinimumSize = new System.Drawing.Size(100, 100);
            this.stNodeEditor1.Name = "stNodeEditor1";
            this.stNodeEditor1.Size = new System.Drawing.Size(1112, 768);
            this.stNodeEditor1.TabIndex = 0;
            this.stNodeEditor1.Text = "stNodeEditor1";
            // 
            // stNodeTreeView1
            // 
            this.stNodeTreeView1.AllowDrop = true;
            this.stNodeTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.stNodeTreeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stNodeTreeView1.FolderCountColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stNodeTreeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.stNodeTreeView1.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.stNodeTreeView1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.stNodeTreeView1.Location = new System.Drawing.Point(0, 0);
            this.stNodeTreeView1.MinimumSize = new System.Drawing.Size(100, 60);
            this.stNodeTreeView1.Name = "stNodeTreeView1";
            this.stNodeTreeView1.ShowFolderCount = true;
            this.stNodeTreeView1.Size = new System.Drawing.Size(248, 301);
            this.stNodeTreeView1.TabIndex = 1;
            this.stNodeTreeView1.Text = "stNodeTreeView1";
            this.stNodeTreeView1.TextBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.stNodeTreeView1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel1.Controls.Add(this.stNodePropertyGrid1);
            this.dSkinPanel1.Controls.Add(this.stNodeTreeView1);
            this.dSkinPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dSkinPanel1.Location = new System.Drawing.Point(0, 0);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(248, 768);
            this.dSkinPanel1.TabIndex = 2;
            // 
            // stNodePropertyGrid1
            // 
            this.stNodePropertyGrid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.stNodePropertyGrid1.DescriptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(184)))), ((int)(((byte)(134)))), ((int)(((byte)(11)))));
            this.stNodePropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stNodePropertyGrid1.ErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(165)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.stNodePropertyGrid1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stNodePropertyGrid1.ForeColor = System.Drawing.Color.White;
            this.stNodePropertyGrid1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.stNodePropertyGrid1.ItemValueBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.stNodePropertyGrid1.Location = new System.Drawing.Point(0, 301);
            this.stNodePropertyGrid1.MinimumSize = new System.Drawing.Size(120, 50);
            this.stNodePropertyGrid1.Name = "stNodePropertyGrid1";
            this.stNodePropertyGrid1.ShowTitle = true;
            this.stNodePropertyGrid1.Size = new System.Drawing.Size(248, 467);
            this.stNodePropertyGrid1.TabIndex = 2;
            this.stNodePropertyGrid1.Text = "节点属性编辑";
            this.stNodePropertyGrid1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.移除ToolStripMenuItem,
            this.锁定解锁位置ToolStripMenuItem,
            this.锁定解锁连接ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.编辑ToolStripMenuItem.Text = "编辑";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 移除ToolStripMenuItem
            // 
            this.移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
            this.移除ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.移除ToolStripMenuItem.Text = "移除";
            this.移除ToolStripMenuItem.Click += new System.EventHandler(this.移除ToolStripMenuItem_Click);
            // 
            // 锁定解锁位置ToolStripMenuItem
            // 
            this.锁定解锁位置ToolStripMenuItem.Name = "锁定解锁位置ToolStripMenuItem";
            this.锁定解锁位置ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.锁定解锁位置ToolStripMenuItem.Text = "锁定/解锁位置";
            this.锁定解锁位置ToolStripMenuItem.Click += new System.EventHandler(this.锁定解锁位置ToolStripMenuItem_Click);
            // 
            // 锁定解锁连接ToolStripMenuItem
            // 
            this.锁定解锁连接ToolStripMenuItem.Name = "锁定解锁连接ToolStripMenuItem";
            this.锁定解锁连接ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.锁定解锁连接ToolStripMenuItem.Text = "锁定/解锁连接";
            this.锁定解锁连接ToolStripMenuItem.Click += new System.EventHandler(this.锁定解锁连接ToolStripMenuItem_Click);
            // 
            // WorkFlowControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.stNodeEditor1);
            this.Controls.Add(this.dSkinPanel1);
            this.Name = "WorkFlowControl";
            this.Size = new System.Drawing.Size(1360, 768);
            this.Load += new System.EventHandler(this.WorkFlowControl_Load);
            this.dSkinPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ST.Library.UI.NodeEditor.STNodeEditor stNodeEditor1;
        private ST.Library.UI.NodeEditor.STNodeTreeView stNodeTreeView1;
        private DSkin.Controls.DSkinPanel dSkinPanel1;
        private ST.Library.UI.NodeEditor.STNodePropertyGrid stNodePropertyGrid1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锁定解锁位置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锁定解锁连接ToolStripMenuItem;
    }
}
