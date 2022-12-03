using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafee.DAO;
using Cafee.DTO;
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
    }
}
