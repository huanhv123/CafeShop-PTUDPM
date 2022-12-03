using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cafee.DTO;
namespace Cafee.DAO
{
    internal class TableDao
    {
        private static TableDao instance;
        public static TableDao Instance
        {
            get
            {
                if (instance == null)
                { instance = new TableDao(); }
                return TableDao.instance;
            }
            private set { TableDao.instance = value; }
        }
        private TableDao() { }
        private Table newTable(DataRow row)
        {
            Table table = new Table()
            {
                id = (int)row["id"],
                name = row["Name"].ToString(),
                status = (int)row["Status"],
            };
            return table;
        }
        public List<Table> LoadTableList()
        {
            List<Table> tables = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TableFood");
            foreach (DataRow item in data.Rows)
            {
                Table table = newTable(item);
                tables.Add(table);
            }
            return tables;
        }
        public Table GetDetailTable(int id)
        {
            Table table = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TableFood where id= @id", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                table = newTable(item);
            }
            return table;
        }
        public bool AddTable(Table newTable)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "INSERT INTO TableFood(name, status) VALUES( @name , @status )",
                new object[] { newTable.name, newTable.status, newTable.id });
            if (result == true)
                return true;
            return false;
        }
        public bool UpdateTable(Table newTable)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "UPDATE TableFood SET name= @name ,status= @status where id= @ID",
                new object[] { newTable.name, newTable.status, newTable.id });
            if (result == true)
                return true;
            return false;
        }
        public bool DeteleTable(int id)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "DELETE FROM TableFood where id= @id ",
                new object[] { id });
            if (result == true)
                return true;
            return false;
        }
        public bool SwitchTable(int idFisrt, int idSecound)
        {
            var result = DataProvider.Instance.ExecuteNonQurey("USP_SwitchTable @idTableFirst , @idTableSeconr ", new object[] { idFisrt, idSecound });
            if (result == true)
                return true;
            return false;
        }
    }
}
