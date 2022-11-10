using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Tables
{
    public class Managers
    {
        SqlConnection conn;
        public Managers()
        {
            string connStr = @"Server =  TAMIM\SQLEXPRESS ; Database = Hopital_DB; Integrated Security = true";
            conn = new SqlConnection(connStr);
        }
        public List <Manager> GetAllManagers()
        {
            string query = "select * from Managers";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Manager> data = new List<Manager>();

            while (reader.Read())
            {
                Manager mng = new Manager();
                mng.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                mng.Name = reader.GetString(reader.GetOrdinal("Name"));
                mng.UserName = reader.GetString(reader.GetOrdinal("Username"));
                mng.Password = reader.GetString(reader.GetOrdinal("Password"));
                mng.Address = reader.GetString(reader.GetOrdinal("Address"));
                mng.Salary = reader.GetString(reader.GetOrdinal("Salary"));
                data.Add(mng);
            }
            conn.Close();
            return data;
        }
        public Manager GetManager(int id)
        {
            string query = "select * from Managers where Id = " + id;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Manager mng = null;
            while (reader.Read())
            {
                mng = new Manager();
                mng.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                mng.Name = reader.GetString(reader.GetOrdinal("Name"));
                mng.UserName = reader.GetString(reader.GetOrdinal("Username"));
                mng.Password = reader.GetString(reader.GetOrdinal("Password"));
                mng.Address = reader.GetString(reader.GetOrdinal("Address"));
                mng.Salary = reader.GetString(reader.GetOrdinal("Salary"));
            }
            conn.Close();
            return mng;
        }
        public bool Insert(Manager mng)
        {
            string query = String.Format("Insert into Managers values ('{0}','{1}','{2}','{3}','{4}','{5}')", mng.Id, mng.Name, mng.UserName, mng.Password, mng.Address, mng.Salary);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public Manager Search(string uname)
        {
            string query = String.Format("select * from Managers where Username='{0}'", uname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Manager mng = null;
            while (reader.Read())
            {
                mng = new Manager();
                mng.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                mng.Name = reader.GetString(reader.GetOrdinal("Name"));
                mng.UserName = reader.GetString(reader.GetOrdinal("Username"));
                mng.Password = reader.GetString(reader.GetOrdinal("Password"));
                mng.Address = reader.GetString(reader.GetOrdinal("Address"));
                mng.Salary = reader.GetString(reader.GetOrdinal("Salary"));
            }
            conn.Close();
            return mng;

        }
        public bool Update(Manager mng)
        {
            string query = String.Format("Update Managers set Name='{0}' , Address='{1}' , Salary='{2}' where Username='{3}'", mng.Name, mng.Address, mng.Salary, mng.UserName);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool Delete(string username)
        {
            string query = String.Format("delete from Managers where Username='{0}'", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }
    }
}
