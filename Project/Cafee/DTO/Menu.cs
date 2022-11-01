using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.DTO
{
    internal class Menu
    {
        public float totalPrice { get; set; }
        public float price { get; set; }
        public int count { get; set; }
        public string foodName { get; set; }
    }
}
