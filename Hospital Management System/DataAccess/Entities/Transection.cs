using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Transection
    {
        public string Date { get; set; }
        public string UserName { get; set; }
        public string Cost { get; set; }
        public string Paid { get; set; }
        public string Pending { get; set; }
    }
}
