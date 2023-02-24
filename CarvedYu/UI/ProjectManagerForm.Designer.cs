namespace CarvedYu.UI
{
    partial class ProjectManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_createProject = new DSkin.Controls.DSkinButton();
            this.dSkinListBox1 = new DSkin.Controls.DSkinListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dSkinListBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_createProject
            // 
            this.btn_createProject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_createProject.ButtonBorderWidth = 0;
            this.btn_createProject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_createProject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_createProject.ForeColor = System.Drawing.Color.White;
            this.btn_createProject.HoverColor = System.Drawing.Color.Empty;
            this.btn_createProject.HoverImage = null;
            this.btn_createProject.Location = new System.Drawing.Point(21, 37);
            this.btn_createProject.Name = "btn_createProject";
            this.btn_createProject.NormalImage = null;
            this.btn_createProject.PressColor = System.Drawing.Color.Empty;
            this.btn_createProject.PressedImage = null;
            this.btn_createProject.Radius = 5;
            this.btn_createProject.ShowButtonBorder = true;
            this.btn_createProject.Size = new System.Drawing.Size(100, 40);
            this.btn_createProject.TabIndex = 0;
            this.btn_createProject.Text = "新建工程";
            this.btn_createProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_createProject.TextPadding = 0;
            this.btn_createProject.Click += new System.EventHandler(this.btn_createProject_Click);
            // 
            // dSkinListBox1
            // 
            this.dSkinListBox1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinListBox1.ItemSize = new System.Drawing.Size(245, 130);
            this.dSkinListBox1.Location = new System.Drawing.Point(21, 83);
            this.dSkinListBox1.Name = "dSkinListBox1";
            this.dSkinListBox1.ScrollBarWidth = 12;
            this.dSkinListBox1.Size = new System.Drawing.Size(996, 550);
            this.dSkinListBox1.SmoothScroll = true;
            this.dSkinListBox1.TabIndex = 1;
            this.dSkinListBox1.Ulmul = true;
            this.dSkinListBox1.Value = 0D;
            // 
            // ProjectManagerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.dSkinListBox1);
            this.Controls.Add(this.btn_createProject);
            this.DoubleClickMaximized = false;
            this.DragChangeBackImage = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectManagerForm";
            this.ShadowWidth = 6;
            this.ShowShadow = true;
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.dSkinListBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinButton btn_createProject;
        private DSkin.Controls.DSkinListBox dSkinListBox1;
    }
}