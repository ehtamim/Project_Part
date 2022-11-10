using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Tables
{
    public class Reviews
    {
        SqlConnection conn;
        public Reviews()
        {
            string connStr = @"Server =  TAMIM\SQLEXPRESS ; Database = Hopital_DB; Integrated Security = true";
            conn = new SqlConnection(connStr);
        }
        public List<Review> GetAllReviews()
        {
            string query = "select * from Reviews";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Review> data = new List<Review>();

            while (reader.Read())
            {
                Review rev = new Review();
                rev.SerialNo = reader.GetInt32(reader.GetOrdinal("SerialNo"));
                rev.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                rev.Rating = reader.GetString(reader.GetOrdinal("Rating"));
                rev.Comment = reader.GetString(reader.GetOrdinal("Comment"));
                data.Add(rev);
            }
            conn.Close();
            return data;
        }
    }
}
