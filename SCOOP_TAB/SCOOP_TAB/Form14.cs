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
using System.IO;

namespace SCOOP_TAB
{
    public partial class Form14 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form14()
        {
            InitializeComponent();
            textBox1.Text = Form5.user3;
            textBox2.Text = Form5.pass3;
            Check();
        }
        void Check()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select* from employee_tbl where username=@user and pass=@pass ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox3.Text = dr.GetValue(0).ToString();
                textBox4.Text = dr.GetValue(1).ToString();
                textBox5.Text = dr.GetValue(2).ToString();
                textBox6.Text = dr.GetValue(3).ToString();
                textBox7.Text = dr.GetValue(4).ToString();
                textBox8.Text = dr.GetValue(5).ToString();
                byte[] imgg = (byte[])(dr["pic"]);
                if (imgg == null)
                {
                    pictureBox1.Image = Properties.Resources.no_image_avaiable;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(imgg);
                    pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                }
            }
            con.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox6.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox6.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update employee_tbl set id=@id, name=@name, username=@user,pass=@pass,location=@loc,pic=@img where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox3.Text);
            cmd.Parameters.AddWithValue("@name", textBox4.Text);
            cmd.Parameters.AddWithValue("@user", textBox5.Text);
            cmd.Parameters.AddWithValue("@pass", textBox6.Text);
            cmd.Parameters.AddWithValue("@loc", textBox7.Text);
            cmd.Parameters.AddWithValue("@img", SavePhoto());
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Data Updated Successfully ! ");
                ResetContro();
            }
            else
            {
                MessageBox.Show("Data not Updated ! ");
            }
            con.Close();
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File (All files) *.* | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }
        void ResetContro()
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            pictureBox1.Image = Properties.Resources.no_image_avaiable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from employee_tbl where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a >= 0)
            {
                MessageBox.Show("Account Deleted Successfully ! ");
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
                ResetContro();
            }
            else
            {
                MessageBox.Show("Data not Deleted ! ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetContro();
        }
    }
}
