using CarvedYu.UI.MainForm;
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

namespace CarvedYu
{
    public partial class Form1 : DSkinForm
    {
        WorkFlowControl workFlowControl = new WorkFlowControl();
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine( this.Padding);
            controlHost1.Controls.Add(this.workFlowControl);
            workFlowControl.Dock= DockStyle.Fill;
        }
    }
}
