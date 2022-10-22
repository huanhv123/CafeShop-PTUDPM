using Cafee.DTO;
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
            LoadTable();
        }
        void LoadTable()
        {
            List<Table> tables = TableDao.Instance.LoadTableList();
            foreach (Table item in tables)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Click += Btn_Click;
                btn.Tag = item;
                if (item.status==1)
                {
                    btn.Text = item.name + Environment.NewLine + "Có người";
                    btn.BackColor = Color.OrangeRed;
                }
                else
                {
                    btn.Text = item.name + Environment.NewLine + "Trống";
                    btn.BackColor = Color.MediumSpringGreen;
                }
                this.flpTable.Controls.Add(btn);

            }
        }
        void ShowBill(int id)
        {

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = (sender as Table).id;
            ShowBill(tableID);
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
