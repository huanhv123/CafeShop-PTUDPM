using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private AccountDAO() { }
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
                    account = new Account()
                    {
                        id = (int)row["id"],
                        username = (string)row["UserName"],
                        displayName = (string)row["DisplayName"],
                        password = (string)row["PassWord"],
                        type = (int)row["Type"],
                    };
                }
            }
            return account;
        }
    }
}
