using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.DTO
{
    internal class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        public int idFoodCate { get; set; }
        public double price { get; set; }
        public string image { get; set; }
    }
}
