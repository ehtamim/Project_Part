using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SCOOP_TAB
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        int v=0,m = 0,n=0,o=0,p=0;
        public static string name1,pass1,name2,pass2,name3,pass3,name4,pass4;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Enter your username please");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Enter your password please");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con1 = new SqlConnection(cs);
                SqlConnection con2 = new SqlConnection(cs);
                SqlConnection con3 = new SqlConnection(cs);
                SqlConnection con4 = new SqlConnection(cs);
                string query1 = "select* from owner_tbl where username=@user1 and pass=@pass1 ";
                string query2 = "select* from manager_tbl where username=@user2 and pass=@pass2 ";
                string query3 = "select* from employee_tbl where username=@user3 and pass=@pass3 ";
                string query4 = "select* from customer_tbl where username=@user4 and pass=@pass4 ";
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                SqlCommand cmd2 = new SqlCommand(query2, con2);
                SqlCommand cmd3 = new SqlCommand(query3, con3);
                SqlCommand cmd4 = new SqlCommand(query4, con4);
                cmd1.Parameters.AddWithValue("@user1", textBox1.Text);
                cmd1.Parameters.AddWithValue("@pass1", textBox2.Text);
                cmd2.Parameters.AddWithValue("@user2", textBox1.Text);
                cmd2.Parameters.AddWithValue("@pass2", textBox2.Text);
                cmd3.Parameters.AddWithValue("@user3", textBox1.Text);
                cmd3.Parameters.AddWithValue("@pass3", textBox2.Text);
                cmd4.Parameters.AddWithValue("@user4", textBox1.Text);
                cmd4.Parameters.AddWithValue("@pass4", textBox2.Text);
                con1.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.HasRows == true)
                {
                    MessageBox.Show("Log In Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Form3.name1 =dr1.GetValue(1).ToString();
                    //Form3.user1 = dr1.GetValue(2).ToString();
                    //Form3.pass1 = dr1.GetValue(3).ToString();
                    //Form3.loc1=dr1.GetValue(4).ToString();
                    Form3.user1 = textBox1.Text;
                    Form3.pass1 = textBox2.Text;
                    this.v = 1;
                    m = 1;
                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.Show();
                }
                /*else
                {
                    this.m = 1;
                }*/
                con1.Close();
                con2.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.HasRows == true)
                {
                    MessageBox.Show("Log In Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Form4.name2= dr2.GetValue(1).ToString();
                    //Form4.user2 = dr2.GetValue(2).ToString();
                    //Form4.pass2 = dr2.GetValue(3).ToString();
                    //Form4.loc2 = dr2.GetValue(4).ToString();
                    Form4.user2 = textBox1.Text;
                    Form4.pass2 = textBox2.Text;
                    this.v = 1;
                    n = 1;
                    this.Hide();
                    Form4 f4 = new Form4();
                    f4.Show();
                }
                con2.Close();
                con3.Open();
                SqlDataReader dr3 = cmd3.ExecuteReader();
                if (dr3.HasRows == true)
                {
                    MessageBox.Show("Log In Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Form5.name3 = dr3.GetValue(1).ToString();
                    //Form5.user3 = dr3.GetValue(2).ToString();
                    //Form5.pass3 = dr3.GetValue(3).ToString();
                    //Form5.loc3 = dr3.GetValue(4).ToString();
                    Form5.user3 = textBox1.Text;
                    Form5.pass3 = textBox2.Text;
                    this.v = 1;
                    o = 1;
                    this.Hide();
                    Form5 f5 = new Form5();
                    f5.Show();
                }
                con3.Close();
                con4.Open();
                SqlDataReader dr4 = cmd4.ExecuteReader();
                if (dr4.HasRows == true)
                {
                    MessageBox.Show("Log In Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Form6.name4 = dr4.GetValue(1).ToString();
                    //Form6.user4 = dr4.GetValue(2).ToString();
                    //Form6.pass4 = dr4.GetValue(3).ToString();
                    //Form6.loc4 = dr4.GetValue(4).ToString();
                    Form6.user4 = textBox1.Text;
                    Form6.pass4 = textBox2.Text;
                    this.v = 1;
                    p = 1;
                    this.Hide();
                    Form6 f6 = new Form6();
                    f6.Show();
                }
                con4.Close();
                if (v == 1)
                {
                    //MessageBox.Show("Log In Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    v = 0;
                }
                else if (m == 0 && n == 0 && o == 0 && p == 0)
                {
                    MessageBox.Show("Log In Failed !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please fill the form", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
