using Cafee.DAO;
using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Cafee.BUS
{
    internal class BillBUS
    {
        private static BillBUS instance;

        public static BillBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new BillBUS(); }
                return BillBUS.instance;
            }
            private set { BillBUS.instance = value; }
        }
        private BillBUS() { }
        public int GetUnCheckBillIdByTableId(int id)
        {
            return BillDAO.Instance.GetUnCheckBillIdByTableId(id);
        }
        public bool InsertBill(int id,int idEmployees)
        {
            return BillDAO.Instance.InsertBill(id, idEmployees);
        }
        public int GetMaxIdBill()
        {
            return BillDAO.Instance.GetMaxIdBill();
        }
        public bool CheckOut(Bill bill)
        {
            return BillDAO.Instance.CheckOut(bill);
        }
        public List<Bill> ListALLBill()
        {
            List<Bill> bills = BillDAO.Instance.LoadBillList();
            return bills;
        }
        public Bill GetDetails(int id)
        {
            Bill bill = BillDAO.Instance.GetDetails(id);
            return bill;
        }
        public bool UpdateBill(Bill bill)
        {
            return BillDAO.Instance.UpdateBill(bill);
        }
        public bool DeleteBill(int idBill, int idTable)
        {
            return BillDAO.Instance.DeleteBill( idBill,  idTable);
        }
    }
}
