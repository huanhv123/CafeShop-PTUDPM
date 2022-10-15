using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cafee.BUS;
namespace Cafee
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            //LoadAccountList();
            cbTypeAcount.Items.Add("1");
            cbTypeAcount.Items.Add("0");
        }


        void LoadAccountList()
        {
            string query = "select * from Account";
            //string query = "select * from Account where (id= @id )and(DisplayName= @display )";
            //string query = "select * from Account where id= @id";
            this.dgvAccount.DataSource = DataProvider.Instance.ExecuteSelectIdQuery(query,1);
            //this.dgvAccount.DataSource = provider.ExecuteSelectIdQuery(query,new object[] {1,"hao"});
        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            //string query = "select * from Account where id=1";
            //DataProvider provider = new DataProvider();
            //DataTable acountData = provider.ExecuteQuery(query);
            //foreach ( DataRow acount in acountData.Rows)
            //{
            //    txtAccountUserName = acountData["UserName"].ToString();
            //}
        }

        private void dagvAccount_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                int ID = int.Parse(dgvAccount.SelectedRows[0].Cells["ID"].Value.ToString());
                Account account = AccountBUS.Instance.GetDetail(ID);
                if (account != null)
                {
                    txtAccountUserName.Text = account.username;
                    txtDisplayName.Text = account.displayName;
                    cbTypeAcount.Text = account.type.ToString();

                    //txt
                    //txt_name.Text = iphone.Name;
                    //txt_series.Text = iphone.Series;
                    //txt_color.Text = iphone.Color;
                    //txt_price.Text = iphone.Price.ToString();

                }
            }
        }

      
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE ?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int ID = int.Parse(dgvAccount.SelectedRows[0].Cells["ID"].Value.ToString());
                bool result = AccountBUS.Instance.Delete(ID);
                if (result)
                {
                    List<Account> accounts = AccountBUS.Instance.GetAll();
                    dgvAccount.DataSource = accounts;
                }
                else
                {
                    MessageBox.Show("Delet Fail!");
                }
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            List<Account> accounts = AccountBUS.Instance.GetAll();
            dgvAccount.DataSource=accounts;
        }

        //private void button7_Click(object sender, EventArgs e)
        //{

        //}
        private void btn_update_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                id = int.Parse(dgvAccount.SelectedRows[0].Cells["ID"].Value.ToString()),
                username = txtAccountUserName.Text,
                displayName = txtDisplayName.Text,
                type = cbTypeAcount.SelectedIndex,
                //ID = int.Parse(txt_id.Text.Trim()),
                //Name = txt_name.Text.Trim(),
                //Color = txt_color.Text.Trim(),
                //Series = txt_series.Text.Trim(),
                //Price = int.Parse(txt_price.Text),

            };
            bool result = AccountBUS.Instance.Update(account);


            if (result)
            {
                List<Account> accounts = AccountBUS.Instance.GetAll();
                dgvAccount.DataSource = accounts;
            }
            else
            {
                MessageBox.Show("Update Fail!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.Show();
        }

        //private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
