using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Tables
{
   public class Admins
    {
        SqlConnection conn;
        public Admins()
        {
            string connStr = @"Server = TAMIM\SQLEXPRESS ; Database = Hopital_DB; Integrated Security = true";
            conn = new SqlConnection(connStr);
        }

        public bool CheckLogin(string username, string password)
        {
            string query = String.Format("select Name from Admins where Username='{0}' and Password='{1}'", username, password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            return false;

        }
        public Admin Search(string uname)
        {
            string query = String.Format("select * from Admins where Username='{0}'", uname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin adm = null;
            while (reader.Read())
            {
                adm = new Admin();
                adm.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                adm.Name = reader.GetString(reader.GetOrdinal("Name"));
                
                adm.UserName = reader.GetString(reader.GetOrdinal("Username"));
                adm.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return adm;

        }
        public bool Update(Admin adm)
        {
            string query = String.Format("Update Admins set Name='{0}' , Password='{1}' where Username='{2}'", adm.Name, adm.Password, adm.UserName);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool Delete(string username)
        {
            string query = String.Format("delete from Admins where Username='{0}'", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }
    }
}
