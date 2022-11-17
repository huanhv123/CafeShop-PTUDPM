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
    public partial class FormAccountProfile : Form
    {
        private Account accountLogin;
        internal Account AccountLogin
        {
            get => accountLogin;
            set => accountLogin = value;
        }
        public FormAccountProfile(Account acc)
        {
            InitializeComponent();
            this.accountLogin = acc;
        }
        private void FormAccountProfile_Load(object sender, EventArgs e)
        {
            ChangeAccount(this.accountLogin);
        }
        void ChangeAccount(Account account)
        {
            txtDispalyName.Text = account.displayName;
            txtUserName.Text = account.username;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProfile();
        }
        void UpdateProfile()
        {
            string displayName = txtDispalyName.Text;
            string password = txtPass.Text;
            string newPass = txtNewPass.Text;
            string userName = txtUserName.Text;
            string reenterPass = txtReEnterPass.Text;
            if (!newPass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                bool result = AccountBUS.Instance.UpdateProfile(accountLogin.id, userName, displayName, password, newPass);
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateProfileAcount != null)
                    {
                        updateProfileAcount(this, new AccountEvent(AccountBUS.Instance.GetAccountByUsername(userName)));
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu ");
                }
            }
        }
        private event EventHandler<AccountEvent> updateProfileAcount;
        public event EventHandler<AccountEvent> UpdateProfileAcount
        {
            add { updateProfileAcount += value; }
            remove { updateProfileAcount -= value; }
        }
    }
    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc 
        { 
            get => acc;
            set => acc = value; 
        }
        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
