using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafee.DAO;
using Cafee.DTO;
using Cafee.BUS;
namespace Cafee
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                id = 0,
                username = txtUserName.Text.Trim(),
                displayName = txtDispalyName.Text.Trim(),   
                password = txtPass.Text.Trim(),
                type = int.Parse(txtType.Text.Trim()),
                //ID = 0,
                //Name = txt_name.Text.Trim(),
                //Color = txt_color.Text.Trim(),
                //Series = txt_series.Text.Trim(),
                //Price = int.Parse(txt_price.Text),

            };
            bool result = AccountBUS.Instance.AddNew(account);


            if (result)
            {
                List<Account> accounts = AccountBUS.Instance.GetAll();
                this.Close();
            }
            else
            {
                MessageBox.Show("Add Fail!");
            }

        }
    }
}
