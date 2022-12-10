using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.DTO
{
    internal class BillInfo
    {
        public int id { get; set; }
        public int idBill { get; set; }
        public int idFood { get; set; }
        public int count { get; set; }
    }
}
