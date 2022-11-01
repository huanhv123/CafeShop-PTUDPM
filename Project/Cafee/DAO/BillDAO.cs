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
            Bill bill = new Bill();
            bill.id= (int)row["id"];
            bill.DateCheckIn = (DateTime?)row["DateCheckIn"];
            var dataCheckOutTemp = row["DateCheckOut"];
            if (dataCheckOutTemp.ToString()!="")
            {
                bill.DateCheckOut = (DateTime?)dataCheckOutTemp;
            }
            bill.idTable = (int)row["idTable"];
            bill.status = (int)row["status"];
            return bill;
        }
        public int GetUnCheckBillIdByTableId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where idTable= "+ id +" and status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = newBill(data.Rows[0]);
                return bill.id;
            }
            return -1;
        }
        public void InsertBill(int id)
        {
           DataProvider.Instance.ExecuteNonQurey(
                "INSERT INTO Bill(DateCheckIn,DateCheckOut,idTable,status) VALUES( GETDATE(), NULL, @idTable ,0 )",
                new object[] { id });
        }
        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(id) from Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOut(int id)
        {
            DataProvider.Instance.ExecuteNonQurey(
                "UPDATE Bill SET status= 1 where id= @ID",
            new object[] { id });
        }
    }
}
