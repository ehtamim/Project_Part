using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Patient
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Age { get; set; }
        public string Diseases { get; set; }
        public string AddmittedDate { get; set; }
        public string ReleasingDate { get; set; }

    }
}
