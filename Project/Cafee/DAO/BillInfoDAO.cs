using Cafee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.DAO
{
    internal class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                { instance = new BillInfoDAO(); }
                return BillInfoDAO.instance;
            }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }
        private BillInfo newBillInfo(DataRow row)
        {
            BillInfo billInfo = new BillInfo()
            {
                id = (int)row["id"],
                idBill = (int)row["idBill"],
                idFood = (int)row["idFood"],
                count = (int)row["count"],
                idEmployee = (int)row["idEmployee"],
            };
            return billInfo;
        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> billInfos = new List<BillInfo>(); 
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfo where idBill= " + id);
            foreach (DataRow  row in data.Rows)
            {
                BillInfo bill = newBillInfo(data.Rows[0]);
                billInfos.Add(bill);
            }
            return billInfos;
        }
        public void InsertBillInfo(int idBill,int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQurey(
                 "USP_InsertBillInfo @idBill , @idFood , @count ",
                 new object[] { idBill,idFood,count });
        }
        public bool Delete(int id)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "DELETE FROM BillInfo where id= @id",
                new object[] { id });
            if (result == true)
                return true;
            return false;
        }
    }
}
