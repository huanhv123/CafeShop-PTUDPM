using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.DTO
{
    public class Employees
    {
        public int id { get; set; }
        public string name { get; set; }

        public  DateTime? birthday { get; set; }

        public string address { get; set; }

        public string phone { get; set; }

        public string position { get; set; }

        public int workingstatus { get; set; }
    }
}
