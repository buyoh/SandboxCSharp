using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandboxCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            TabControl sendedTc = (TabControl)sender;

            TabPage newTab = new TabPage();
            TestViewControl tvc = new TestViewControl();

            tvc.Dock = System.Windows.Forms.DockStyle.Fill;
            tvc.Name = "testViewControl1";
            tvc.TabIndex = 0;

            newTab.Controls.Add(tvc);
            newTab.Name = "tabPage1";
            newTab.Padding = new System.Windows.Forms.Padding(3);
            newTab.TabIndex = 0;
            newTab.Text = "tabPage1";
            newTab.UseVisualStyleBackColor = true;

            tabControl1.TabPages.Add(newTab);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (tabControl1.TabPages.Count > 1)
                    tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            }
        }
    }
}
