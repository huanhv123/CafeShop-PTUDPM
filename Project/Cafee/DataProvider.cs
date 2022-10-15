using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee
{
    internal class DataProvider
    {
        private String strCon;
        private static DataProvider instance;

        public static DataProvider Instance {
            get { if (instance == null) { instance = new DataProvider(); } return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider()
        {
            strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
        }
        
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
                catch (SqlException e)
                {
                    return null;
                }

            }
            return data;
        }
        public DataTable ExecuteSelectIdQuery(string query,int id)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@id", id));
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQurey(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        public bool ExecuteInsertQuery(string query,object[] parameter=null)
        {
            SqlConnection connection = new SqlConnection(strCon);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                //com.Parameters.Add(new SqlParameter("@name", newLaptop.name));
                //com.Parameters.Add(new SqlParameter("@price", newLaptop.price));
                //com.Parameters.Add(new SqlParameter("@brand", newLaptop.brand));
                //com.Parameters.Add(new SqlParameter("@quantity", newLaptop.quantity));
                //command.Parameters.Add(new SqlParameter("@userName", id));
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                command.ExecuteNonQuery();
            }
            catch(SqlException e )
            {
                Console.Write("Error - ExecuteInsertQuery: "+e.ToString());
                return false;
            }
            connection.Close();
            return true;
        }
    }
}
