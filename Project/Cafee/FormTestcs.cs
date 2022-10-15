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
    public partial class FormTestcs : Form
    {
        bool sidebarExpand;
        public FormTestcs()
        {
            InitializeComponent();
        }
        public void loadForm(object Form,string subform)
        {
            if(this.plMain.Controls.Count>0)
            {
                this.plMain.Controls.RemoveAt(0);
            }
            if (subform=="Home")
            {
                this.btnAdmin.BackColor = Color.DimGray;
                this.btnHome.BackColor = Color.SaddleBrown;
            }
            if (subform=="Admin")
            {
                this.btnAdmin.BackColor = Color.SaddleBrown;
                this.btnHome.BackColor = Color.DimGray;
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            this.plMain.Controls.Add(f);
            this.plMain.Tag = f;
            f.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            loadForm(new FormHome(),"Home");
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            loadForm(new FormAdmin(),"Admin");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void logOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                plSidebar.Width -= 10;
                if (plSidebar.Width == plSidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTime.Stop();
                }
            }
            else
            {
                plSidebar.Width += 10;
                if (plSidebar.Width == plSidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
