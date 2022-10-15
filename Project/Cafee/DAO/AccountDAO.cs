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
        String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
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
        public bool Login(string userName, string passWord)
        {
            //string query = "select * from Account where UserName=N'" + userName + "' and [PassWord] = N'" + passWord + "'";
            string query = "select * from Account where UserName=N'tranvanhao@gmail.com' and [PassWord] = N'123456'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            //string query = "USP_Login @userName , @passWord";
            //DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {userName,passWord});
            //string rrr = "";
            //foreach (DataRow row in result.Rows)
            //{
            //  rrr = (string)row["PassWord"] ;
            //}
            //if (passWord == rrr)
            //{
            //    return true;
            //}

            return result.Rows.Count > 0;
            //return false;
        }

        //public Account SelectedByCode(int id)
        //{
        //    Account laptop = null;
        //    SqlConnection con = new SqlConnection(strCon);
        //    con.Open();
        //    String strCom = "select * from Laptop where ID=@id";
        //    select* from Account where username = 'admin';
        //    SqlCommand com = new SqlCommand(strCom, con);
        //    com.Parameters.Add(new SqlParameter("@id", id));
        //    SqlDataReader dr = com.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        laptop = new Laptop()
        //        {
        //            id = (int)dr["ID"],
        //            name = (string)dr["Name"],
        //            price = (int)dr["Price"],
        //            brand = (string)dr["Brand"],
        //            quantity = (int)dr["Quantity"],
        //        };
        //    }
        //    con.Close();
        //    return laptop;
        //}
        public List<Account> SelectAll()
        {
            List<Account> list = new List<Account>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "select * from Account";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Account item = new Account()
                {
                    id = (int)dr["ID"],
                    username = (string)dr["username"],
                    displayName = (string)dr["displayName"],
                    password = (string)dr["password"],
                    type = (int)dr["type"],

                };
                list.Add(item);
            }
            con.Close();
            return list;
        }
        public Account SelectedByCode(int ID)
        {
            Account account = null;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "select * from Account where id=@id";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@id", ID));
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                account = new Account()
                {
                    id = (int)dr["ID"],
                    username = (string)dr["username"],
                    displayName = (string)dr["displayName"],
                    password = (string)dr["password"],
                    type = (int)dr["type"],
                };
            }
            con.Close();
            return account;
        }
        public bool Insert(Account newAccount)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "INSERT INTO Account(username,displayName,password,type) VALUES(@username,@displayName,@password,@type)";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@ID", newAccount.id));
            com.Parameters.Add(new SqlParameter("@username", newAccount.username));
            com.Parameters.Add(new SqlParameter("@displayName", newAccount.displayName));
            com.Parameters.Add(new SqlParameter("@password", newAccount.password));
            com.Parameters.Add(new SqlParameter("@type", newAccount.type));
           

            try
            {
                result = com.ExecuteNonQuery() > 0;
            }
            catch
            {
                result = false;
            }
            con.Close();
            return result;
        }
        public bool Update(Account newAccount)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "UPDATE Account SET displayName=@displayName,type=@type where id=@ID";
            SqlCommand com = new SqlCommand(strCom, con);
            //com.Parameters.Add(new SqlParameter("@username", newAccount.username));
            com.Parameters.Add(new SqlParameter("@displayName", newAccount.displayName));
            com.Parameters.Add(new SqlParameter("@type",newAccount.type));
            com.Parameters.Add(new SqlParameter("@ID", newAccount.id));
            try
            {
                result = com.ExecuteNonQuery() > 0;
            }
            catch
            {
                result = false;
            }
            con.Close();
            return result;

        }
        public bool Delete(int ID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "DELETE FROM Account where id=@id";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@id", ID));
            try
            {
                result = com.ExecuteNonQuery() > 0;
            }
            catch
            {
                result = false;
            }
            con.Close();
            return result;
        }
    }
}
