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
    internal class BillInfoBUS
    {
        private static BillInfoBUS instance;

        public static BillInfoBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new BillInfoBUS(); }
                return BillInfoBUS.instance;
            }
            private set { BillInfoBUS.instance = value; }
        }
        private BillInfoBUS() { }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> billInfos = BillInfoDAO.Instance.GetListBillInfo(id);
            return billInfos;
        }
        public bool InsertBillInfo(int idBill, int idFood, int count)
        {
            return BillInfoDAO.Instance.InsertBillInfo(idBill,  idFood,  count);
        }
        public bool Delete(int id)
        {
            return BillInfoDAO.Instance.Delete(id);
        }
    }
}
