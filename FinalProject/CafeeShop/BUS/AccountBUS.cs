using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public string Encrypt(string encrypt)
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
        public string Decrypt(string decrypt)
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
        public bool Login(string userName, string passWord)
        {
            string passwordDecrypt = Encrypt(passWord);
            Account account = AccountDAO.Instance.Login(userName, passwordDecrypt);
            if (account != null)
            {
                return true;
            }
            return false;
        }
        public Account GetAccountByUsername(string userName)
        {
            Account account = AccountDAO.Instance.GetAccountByUsername(userName);
            return account;
        }
        public bool AddNew(Account account)
        {
            //account.password = Encrypt(account.password);
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
            return AccountDAO.Instance.Delete(ID);
        }
        public List<Account> Search(String key)
        {
            List<Account> accounts = AccountDAO.Instance.SelectByKeyWord(key);
            return accounts;
        }
        public List<Account> GetAllAccount()
        {
            List<Account> list = AccountDAO.Instance.GetListAccount();
            return list;
        }
        public bool Update(Account account)
        {
            return AccountDAO.Instance.Update(account);
        }
        public bool UpdateProfile(int id, string userName, string displayName, string pass, string newPass)
        {
            string passwordInput = Encrypt(pass);
            string passwordNew = Encrypt(newPass);
            return AccountDAO.Instance.UpdateProfile( id, userName,  displayName, passwordInput , passwordNew);
        }
    }
}
