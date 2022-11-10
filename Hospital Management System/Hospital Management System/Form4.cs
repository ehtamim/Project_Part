using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Entities;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class Form4 : Form
    {
        string connStr = @"Server =  TAMIM\SQLEXPRESS ; Database = Hopital_DB; Integrated Security = true";
        public static string un;
        public Form4()
        {
            InitializeComponent();
            Database db = new Database();
            Check();
            
        }

        public void Check()
        {
            SqlConnection conn;
            conn = new SqlConnection(connStr);
            string query = String.Format("select * from Admins where Username='{0}'", un);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader.GetValue(0).ToString();
                textBox2.Text = reader.GetValue(1).ToString();
                textBox3.Text = reader.GetValue(2).ToString();
                textBox4.Text = reader.GetValue(3).ToString();
                
            }
            conn.Close(); ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updatedName = textBox2.Text;
            string updatePass = textBox4.Text;
            string updateAddress = textBox5.Text;
            Admin adm = new Admin();

            adm.UserName = textBox3.Text;
            adm.Name = textBox2.Text;
            adm.Password = textBox4.Text;
           // adm.Address = textBox5.Text;

            Database db = new Database();
            bool rs = db.Admins.Update(adm);
            if (rs)
            {
                MessageBox.Show("Updated");

            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
