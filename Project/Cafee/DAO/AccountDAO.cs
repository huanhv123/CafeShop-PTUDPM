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
    }
}
