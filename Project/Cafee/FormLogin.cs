using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Cafee.DAO;
using Cafee.BUS;
using Cafee.DTO;

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
            string userName = this.txtUsername.Text.Trim();
            string passWord = this.txtPassword.Text.Trim();
            if (Login(userName, passWord))
            {
                Account accountLogin = AccountBUS.Instance.GetAccountByUsername(userName);
                int type = accountLogin.type;
                FormMain formMain = new FormMain(accountLogin);
                //this.Hide();
                formMain.ShowDialog();
                this.Show();
                //this.txt1.Text = Encrypt(txtPassword.Text);
                //string encrypt = Encrypt(txtPassword.Text);
                //this.txt2.Text = Decrypt(encrypt);
            }
            else
            {
                MessageBox.Show("Sai tài khoàn hoặc mật khẩu");
            }
        }
        bool Login(string userName,string passWord)
        {
            return AccountBUS.Instance.Login(userName,passWord);
        }
    }
}