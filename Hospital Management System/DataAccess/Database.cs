using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Tables;

namespace DataAccess
{
   public class Database
    {
        public Admins Admins { get; set; }
        public Managers Managers { get; set; }
        public Patients Patients { get; set; }
        public Reviews Reviews { get; set; }
        public Transections Transections { get; set; }


        public Database()
        {
            /*string connStr = @"Server = DESKTOP-NJLFQBE; Database = Hopital_DB; Integrated Security = true";
             SqlConnection conn = new SqlConnection(connStr);
             Admins = new Admins(conn);*/
            Admins = new Admins();
            Managers = new Managers();
            Patients = new Patients();
            Reviews = new Reviews();
            Transections = new Transections();

        }
    }
}
