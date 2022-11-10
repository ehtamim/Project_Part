using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Tables
{
    public class Transections
    {
        SqlConnection conn;
        public Transections()
        {
            string connStr = @"Server =  TAMIM\SQLEXPRESS ; Database = Hopital_DB; Integrated Security = true";
            conn = new SqlConnection(connStr);
        }
        public List<Transection> GetAllTransections()
        {
            string query = "select * from Transections";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Transection> data = new List<Transection>();

            while (reader.Read())
            {
                Transection tr = new Transection();
                tr.Date= reader.GetString(reader.GetOrdinal("Date"));
                tr.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                tr.Cost = reader.GetString(reader.GetOrdinal("Cost"));
                tr.Paid = reader.GetString(reader.GetOrdinal("Paid"));
                tr.Pending = reader.GetString(reader.GetOrdinal("Pending"));
                data.Add(tr);
            }
            conn.Close();
            return data;
        }
    }
}
