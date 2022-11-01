using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafee
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void gggToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssLabelTime.Text = DateTime.Now.ToString();
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            home.MdiParent = this;
            home.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.MdiParent = this;
            admin.Show();
        }
    }
}
