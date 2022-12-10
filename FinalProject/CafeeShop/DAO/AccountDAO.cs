using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Cafee.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get 
            { 
                if (instance == null)
                    { instance = new AccountDAO();} 
                return AccountDAO.instance; 
            }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() {
        }
        private Account newAccount(DataRow row)
        {
            Account account = new Account()
            {
                id = (int)row["id"],
                username = row["UserName"].ToString(),
                displayName = row["DisplayName"].ToString(),
                //password = row["PassWord"].ToString(),
                type = (int)row["Type"],
                idEmployees= (int)row["idEmployees"]
            };
            return account;
        }
        public Account Login(string userName, string passWord)
        {
            Account account = null;
            //string query = "select * from Account where UserName=N'" + userName + "' and [PassWord] = N'" + passWord + "'";
            //string query = "select * from Account where UserName=N'tranvanhao@gmail.com' and [PassWord] = N'A4F6Mulc9nNnEsyEu58m6w=='";
            //DataTable result = DataProvider.Instance.ExecuteQuery(query);
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    account = newAccount(row);
                }
            }
            return account;
        }
        public Account GetAccountByUsername(string userName)
        {
            Account account = null;
            string query = "select * from Account where UserName= @userName" ;
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName});
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    account = newAccount(row);
                }
            }
            return account;
        }
        public List<Account> SelectByKeyWord(string keyword)
        {
            List<Account> accounts = new List<Account>();
            String query = "SELECT * FROM Account WHERE UserName LIKE @KeyWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    Account item = newAccount(row);
                    accounts.Add(item);
                }
            }
            return accounts;
        }
        public List<Account> GetListAccount()
        {
            List<Account> accounts = new List<Account>();
            String query = "select * from Account ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    Account item = newAccount(row);
                    accounts.Add(item);
                }
            }
            return accounts;
        }
        public Account SelectedByCode(int id)
        {
            Account account = null;
            string query = "select * from Account where id= @id";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {id});
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    account = newAccount(row);
                }
            }
            return account;
        }
        public bool Insert(Account newAccount)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "INSERT INTO Account(username,displayName,password,type) VALUES( @username , @displayName , @password , @type )",
                new object[] {newAccount.username, newAccount.displayName, newAccount.password, newAccount.type });
            if (result == true)
                return true;
            return false;          
        }
        public bool Update(Account newAccount)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "UPDATE Account SET displayName= @displayName ,type= @type where id= @ID",
                new object[] { newAccount.displayName, newAccount.type, newAccount.id });
            if (result == true)
                return true;
            return false;
        }
        public bool UpdateProfile(int id,string userName,string displayName,string pass,string newPass)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "exec USP_UpdateAccount @id , @userName , @displayName  , @password , @newPassword ",
                new object[] { id, userName, displayName, pass, newPass });
            if (result == true)
                return true;
            return false;
        }
        public bool Delete(int id)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "DELETE FROM Account where id= @id",
                new object[] { id });
            if (result == true)
                return true;
            return false;
        }
    }
}
