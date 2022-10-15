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

namespace Cafee
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            LoadAccountList();
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
    }
}
