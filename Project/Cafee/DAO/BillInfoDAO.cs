using System;
using System.Collections.Generic;
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
    }
}
