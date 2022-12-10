using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.DTO
{
    public class Bill
    {
        public int id { get; set; }
        public DateTime? DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int idTable { get; set; }
        public int status { get; set; }
        public int discount { get; set; }
        public float total { get; set; }
        public int idEmployees { get; set; }
    }
}
