using Cafee.BUS;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafee
{
    //tranvanhao
    //hoangvanhuan
    public partial class FormMain : Form
    {
        private Account accountLogin;
        internal Account AccountLogin
        { 
            get => accountLogin;
            set=>accountLogin = value; 
        }
        public FormMain(Account acc)
        {
            InitializeComponent();
            this.accountLogin = acc;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ChangeAccount(accountLogin);
        }
        void ChangeAccount(Account account)
        {
            //tranvanhao
            //hoangvanhuan
            if (account.type == 1)
            {
                sellToolStripMenuItem.Visible = false;
            }
            else
            {
                Employees employees = EmployeesBUS.Instance.GetDetail(accountLogin.idEmployees);
                if (employees.position == "Cashier")
                {
                    adminToolStripMenuItem.Visible = false;
                    statisticalToolStripMenuItem.Visible = false;
                }
                else
                {
                    adminToolStripMenuItem.Visible = false;
                    statisticalToolStripMenuItem.Visible = false;
                    sellToolStripMenuItem.Visible = false;
                }
            }
            tssLabeldisplauName.Text = account.displayName;
            //accountProfileToolStripMenuItem.Text +=" ("+account.displayName+")";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tssLabelTime.Text = DateTime.Now.ToString();
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
        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome(accountLogin.idEmployees);
            home.MdiParent = this;
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            home.Show();
        }
        private void AccountProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountProfile accountProfile = new FormAccountProfile(this.accountLogin);
            accountProfile.MdiParent = this;
            accountProfile.UpdateProfileAcount += _UpdateProfileAcount;
            accountProfile.Show();
        }
        private void _UpdateProfileAcount(object sender, AccountEvent e)
        {
            //accountProfileToolStripMenuItem.Text += " (" + e.Acc.displayName + ")";
            tssLabeldisplauName.Text = e.Acc.displayName;
        }
        private void StatisticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistical statistical = new FormStatistical();
            statistical.MdiParent = this;
            statistical.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            statistical.Dock = DockStyle.Fill;
            statistical.Show();
        }
    }
}
