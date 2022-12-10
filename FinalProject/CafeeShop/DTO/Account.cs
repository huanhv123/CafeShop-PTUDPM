using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee.DTO
{
    public class Account
    {
        public int id { get; set; }
        public string username { get; set; }
        public string displayName { get; set; }
        public string password { get; set; }
        public int type { get; set; }
        public int idEmployees { get; set; }
    }
}
