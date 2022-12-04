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
                //catch (SqlException e)
                catch
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

        public bool ExecuteNonQurey(string query, object[] parameter = null)
        {
         
            bool result = false;
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
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
                    ;
                    result = command.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
                connection.Close();
            }
            return result;
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
    }
}
