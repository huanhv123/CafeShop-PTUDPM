using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Cafee.DAO;

namespace Cafee
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        string hash = "f0xle@rn";
        private string Encrypt(string encrypt)
        {
            //byte[] data = UTF8Encoding.UTF8.GetBytes(encrypt);
            //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //{
            //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
            //    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            //    {
            //        ICryptoTransform transform = tripDes.CreateEncryptor();
            //        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //        return Convert.ToBase64String(results, 0, results.Length);
            //    }
            //}

            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(hash));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] data = Encoding.Unicode.GetBytes(encrypt);
                    return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
        private string Decrypt(string decrypt)
        {
            //byte[] data = Convert.FromBase64String(decrypt);
            //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //{
            //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            //    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            //    {
            //        ICryptoTransform transform = tripDes.CreateDecryptor();
            //        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //        return UTF8Encoding.UTF8.GetString(results);
            //    }
            //}
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(hash));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] byteBuff = Convert.FromBase64String(decrypt);
                    return Encoding.Unicode.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string userName = this.txtUsername.Text;
            //string passWord = this.txtPassword.Text;
            //if (Login(userName, passWord))
            //{
            //FormTestcs formTestcs = new FormTestcs();
            //this.Hide();
            //string query = "select * from Account where username=@userName";
            //DataProvider provider = new DataProvider();
            //provider.ExecuteSelectQuery(query, "admin");
            //formTestcs.ShowDialog();
            //this.Show();
            this.txt1.Text = Encrypt(txtPassword.Text);
            string encrypt = Encrypt(txtPassword.Text);
            this.txt2.Text = Decrypt(encrypt);
            //}
            //else
            //{
            //    MessageBox.Show("Sai tài kho?n ho?c m?t kh?u");
            //}

        }
        bool Login(string userName,string passWord)
        {
            return AccountDAO.Instance.Login(userName,passWord);
        }
    }
}