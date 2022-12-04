using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafee.DAO;
using Cafee.DTO;

namespace Cafee.BUS
{
    internal class TableBUS
    {
        private static TableBUS instance;

        public static TableBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new TableBUS(); }
                return TableBUS.instance;
            }

            private set { TableBUS.instance = value; }
        }
        private TableBUS() { }
        public List<Table> ListALLTable()
        {
            List<Table> tables = TableDao.Instance.LoadTableList();
            return tables;
        }
        
        public bool AddTable(Table newTable)
        {
            return TableDao.Instance.AddTable(newTable);
        }
        public bool UpdateTable(Table table)
        {
            return TableDao.Instance.UpdateTable(table);
        }
        public bool DeteleTable(int id)
        {
            return TableDao.Instance.DeteleTable(id);
        }
        public Table GetDetail(int id)
        {
            Table table = TableDao.Instance.GetDetailTable(id);
            return table;
        }
    }

}
