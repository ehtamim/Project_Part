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
    public partial class Form7 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form7()
        {
            InitializeComponent();
            int bc = Form3.a;
            if (bc==1)
            {
                Check1();
            }
            else
            {
                Check();
                BindGridView();
            }
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
        void Check()
        {
            textBox1.Text = Form6.user4;
            textBox2.Text = Form6.pass4;
            SqlConnection con = new SqlConnection(cs);
            string query = "select* from customer_tbl where username=@user and pass=@pass ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                textBox3.Text = dr.GetValue(0).ToString();
                textBox4.Text = dr.GetValue(1).ToString();
                textBox5.Text = dr.GetValue(2).ToString();
                textBox6.Text = dr.GetValue(3).ToString();
                textBox7.Text = dr.GetValue(4).ToString();
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
        void Check1()
        {
            textBox1.Text = Form3.user1;
            textBox2.Text = Form3.pass1;
            button4.Visible = false;
            dataGridView1.Visible = false;
            label8.Visible = false;
            SqlConnection con = new SqlConnection(cs);
            string query = "select* from owner_tbl where username=@user and pass=@pass ";
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

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select date,item_name,quantity,cost from ordered_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Image Height
            dataGridView1.RowTemplate.Height = 50;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ab = Form3.a;
            if (ab==1)
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
            {
                this.Hide();
                Form6 f6 = new Form6();
                f6.Show();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File (All files) *.* | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
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
            int ab = Form3.a;
            if (ab == 1)
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "update owner_tbl set id=@id, name=@name, username=@user,pass=@pass,location=@loc,pic=@img where id=@id";
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
            else
            {
                SqlConnection con1 = new SqlConnection(cs);
                string query1 = "update customer_tbl set contact=@contact, name=@name, username=@user,pass=@pass,location=@loc,pic=@img where contact=@contact";
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                cmd1.Parameters.AddWithValue("@contact", textBox3.Text);
                cmd1.Parameters.AddWithValue("@name", textBox4.Text);
                cmd1.Parameters.AddWithValue("@user", textBox5.Text);
                cmd1.Parameters.AddWithValue("@pass", textBox6.Text);
                cmd1.Parameters.AddWithValue("@loc", textBox7.Text);
                cmd1.Parameters.AddWithValue("@img", SavePhoto());

                con1.Open();
                int a = cmd1.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Successfully ! ");
                    ResetContro();
                }
                else
                {
                    MessageBox.Show("Data not Updated ! ");
                }
            }


        }
        void ResetContro()
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            checkBox1.Checked = false;
            textBox7.Clear();
            pictureBox1.Image = Properties.Resources.no_image_avaiable;
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetContro();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ab = Form3.a;
            if (ab == 1)
            {
                MessageBox.Show("Cannot delete your account.");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "delete from customer_tbl where contact=@contact";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@contact", textBox3.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a >= 0)
                {
                    MessageBox.Show("Data Deleted Successfully ! ");
                    ResetContro();
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Data not Deleted ! ");
                }
            }
            
        }
    }
}
