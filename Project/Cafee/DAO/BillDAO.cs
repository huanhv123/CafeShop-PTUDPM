using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                { instance = new BillDAO(); }
                return BillDAO.instance;
            }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        private Bill newBill(DataRow row)
        {
            Bill bill = new Bill()
            {
                id = (int)row["id"],
                DateCheckIn = (DateTime)row["DateCheckIn"],
                DateCheckOut = (DateTime)row["DateCheckOut"],
                idTable = (int)row["idTable"],
                status = (int)row["status"],
            };
            return bill;
        }
        public int GetUnCheckBillIdByTableId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where idTable= "+ id +" and status = 1");
            if (data.Rows.Count > 0)
            {
                Bill bill = newBill(data.Rows[0]);
                return bill.id;
            }
            return -1;
        }
    }
}
