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
            if(row["discount"].ToString()!="")
               bill.discount = (int)row["discount"];
            bill.total = (float)Convert.ToDouble(row["Total"]);
            bill.idEmployees=(int)row["idEmployees"];
            return bill;
        }
        public int GetUnCheckBillIdByTableId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where idTable= @id and status = 0",
            new object[] { id });
            if (data.Rows.Count > 0)
            {
                Bill bill = newBill(data.Rows[0]);
                return bill.id;
            }
            return -1;
        }
        public bool InsertBill(int id,int idEmployees)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "INSERT INTO Bill(DateCheckIn,DateCheckOut,idTable,status,discount,Total,idEmployees) VALUES( GETDATE(), NULL, @idTable ,0,0,0, @idEmployees )",
                new object[] { id , idEmployees });
            if (result == true)
                return true;
            return false;
        }
        public List<Bill> LoadBillList()
        {
            List<Bill> bills = new List<Bill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill");
            foreach (DataRow item in data.Rows)
            {
                Bill bill = newBill(item);
                bills.Add(bill);
            }
            return bills;
        }
        public Bill GetDetails(int id )
        {
           Bill bill = null;
            string query = "select * from Bill where id= @id" ;
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id});
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    bill = newBill(row);
                }
            }
            return bill;
        }
        public bool UpdateBill(Bill newBill)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "UPDATE Bill SET DateCheckIn = @DateCheckIn , DateCheckOut = @DateCheckOut , idTable = @idTable , status= @status , Total = @Total where id= @ID",
                new object[] {  newBill.DateCheckIn, newBill.DateCheckOut, newBill.idTable , newBill.status, newBill.total, newBill.id }); 
            if (result == true)
                return true;
            return false;
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
        public bool CheckOut(Bill bill)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "UPDATE Bill SET status= 1 , discount= @discount ,DateCheckOut= @datetime ,idEmployees= @idEmployees ,total= @total where id= @ID ",
            new object[] { bill.discount, bill.DateCheckOut, bill.idEmployees, bill.total, bill.id });
            if (result == true)
                return true;
            return false;
        }
        public bool DeleteBill(int idBill,int idTable)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "exec USP_CancelBill @idBill , @idTable",
                new object[] { idBill, idTable });
            if (result == true)
                return true;
            return false;
        }
    }
}
