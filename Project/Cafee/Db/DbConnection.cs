using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardApp.Db
{
    public abstract class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = "Data Source=LAPTOP-0H23TTCU;Initial Catalog=CafeShop;Persist Security Info=True;User ID=sa;Password=1";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
