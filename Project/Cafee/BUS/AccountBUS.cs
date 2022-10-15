using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.BUS
{
    internal class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new AccountBUS(); }
                return AccountBUS.instance;
            }
            private set { AccountBUS.instance = value; }
        }
        private AccountBUS() { }
        string hash = "f0xle@rn";
        private string Encrypt(string encrypt)
        {
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
        public bool Login()
        {
            return false;
        }
        public bool AddNew(Account account)
        {
            bool result = AccountDAO.Instance.Insert(account);
            return result;
        }
        public Account GetDetail(int ID)
        {
            Account account = AccountDAO.Instance.SelectedByCode(ID);
            return account;
        }
        public bool Delete(int ID)
        {
            bool result = AccountDAO.Instance.Delete(ID);
                
            return result;
        }
        public List<Account> GetAll()
        {
            List<Account> list = AccountDAO.Instance.SelectAll();
            return list;
        }
        public bool Update(Account account)
        {
            bool result = AccountDAO.Instance.Update(account);
            return result;
        }
    }
}
