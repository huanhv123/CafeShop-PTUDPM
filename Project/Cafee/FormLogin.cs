using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Cafee.DAO;
using Cafee.BUS;

namespace Cafee
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = this.txtUsername.Text;
            string passWord = this.txtPassword.Text;
            if (Login(userName, passWord))
            {
                FormTestcs formTestcs = new FormTestcs();
                //this.Hide();
                formTestcs.ShowDialog();
                this.Show();
                //this.txt1.Text = Encrypt(txtPassword.Text);
                //string encrypt = Encrypt(txtPassword.Text);
                //this.txt2.Text = Decrypt(encrypt);
            }
            else
            {
                MessageBox.Show("Sai tài kho?n ho?c m?t kh?u");
            }
        }
        bool Login(string userName,string passWord)
        {
            return AccountBUS.Instance.Login(userName,passWord);
        }
    }
}