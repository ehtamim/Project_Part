using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Tables
{
    public class Patients
    {
        SqlConnection conn;
        public Patients()
        {
            string connStr = @"Server =  TAMIM\SQLEXPRESS ; Database = Hopital_DB; Integrated Security = true";
            conn = new SqlConnection(connStr);
        }
        public List <Patient> GetAllPatients()
        {
            string query = "select * from Patients";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Patient> data = new List<Patient>();

            while (reader.Read())
            {
                Patient pat = new Patient();
                pat.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                pat.Name = reader.GetString(reader.GetOrdinal("Name"));
                pat.UserName = reader.GetString(reader.GetOrdinal("Username"));
                pat.Diseases = reader.GetString(reader.GetOrdinal("Diseases"));
                pat.AddmittedDate = reader.GetString(reader.GetOrdinal("AddmittedDate"));
                pat.ReleasingDate = reader.GetString(reader.GetOrdinal("ReleasingDate"));
                data.Add(pat);
            }
            conn.Close();
            return data;
        }
    }
}
