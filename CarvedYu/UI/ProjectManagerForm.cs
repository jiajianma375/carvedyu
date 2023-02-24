using CarvedYu.DataManager;
using CarvedYu.UI.TemplateControl;
using DSkin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarvedYu.UI
{
    public partial class ProjectManagerForm : DSkinForm
    {
        public ProjectManagerForm()
        {
            InitializeComponent();
        }

        private void btn_createProject_Click(object sender, EventArgs e)
        {
            CYProject project  = new CYProject();
            CYProjectManager.AddProject(project);
            ProjectTemplate template = new ProjectTemplate(project.ID);
            dSkinListBox1.Items.Add(template);
        }
    }
}
