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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void LogoutToolStripMenuItem(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accountProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountProfile accountProfile = new FormAccountProfile();
            accountProfile.ShowDialog();

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.ShowDialog();
        }

    }
}
