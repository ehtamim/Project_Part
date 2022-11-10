using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Review
    {
        public int SerialNo { get; set; }
        public string UserName { get; set; }
        public string Rating { get; set; }
        public string Comment { get; set; }
    }
}
