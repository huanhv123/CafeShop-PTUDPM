
﻿using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            List<Table> tables = TableDAO.Instance.LoadTableList();
            return tables;
        }
        public Table GetDetailTable(int id)
        {
            Table table = TableDAO.Instance.GetDetailTable(id);
            return table;
        }
        public bool SwitchTable(int idFisrt, int idSecound, int idEmployees)
        {
            return TableDAO.Instance.SwitchTable(idFisrt,idSecound,idEmployees);
        }    
        public bool AddTable(Table newTable)
        {
            return TableDAO.Instance.AddTable(newTable);
        }
        public bool UpdateTable(Table table)
        {
            return TableDAO.Instance.UpdateTable(table);
        }
        public bool DeteleTable(int id)
        {
            return TableDAO.Instance.DeteleTable(id);
        }
        public Table GetDetail(int id)
        {
            Table table = TableDAO.Instance.GetDetailTable(id);
            return table;
        }
    }

}
