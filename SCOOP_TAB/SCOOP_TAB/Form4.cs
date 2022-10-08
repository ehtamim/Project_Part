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
    public partial class Form4 : Form
    {
        public static string name2, pass2,loc2,user2;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        int mou = 0;
        public Form4()
        {
            InitializeComponent();
            Check();
        }
        void Check()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select* from manager_tbl where username=@user and pass=@pass ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", Form4.user2);
            cmd.Parameters.AddWithValue("@pass", Form4.pass2);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr.GetValue(0).ToString();
                textBox1.Text = dr.GetValue(1).ToString();
                textBox3.Text = dr.GetValue(4).ToString();
                byte[] imgg = (byte[])(dr["pic"]);
                if (imgg == null)
                {
                    pictureBox3.Image = Properties.Resources.no_image_avaiable;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(imgg);
                    pictureBox3.Image = System.Drawing.Image.FromStream(mstream);
                }
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reset2();
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mou = 1;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            label3.Visible = true;
            pictureBox3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            linkLabel1.Visible = true;
            button5.Visible = true;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            //mou = 1;
            label3.Visible = true;
            pictureBox3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            linkLabel1.Visible = true;
            button5.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (mou == 1)
            {
                
            }
            else
            {
                label3.Visible = false;
                pictureBox3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                linkLabel1.Visible = false;
                button5.Visible = false;
            }
        }

        private void Form4_Click(object sender, EventArgs e)
        {
            mou = 0;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            label3.Visible = false;
            pictureBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            linkLabel1.Visible = false;
            button5.Visible = false;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form15 f15 = new Form15();
            f15.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mou = 0;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            label3.Visible = false;
            pictureBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            linkLabel1.Visible = false;
            button5.Visible = false;
        }

        void Reset2()
        {
            name2 = "";
            pass2 = "";
            loc2= "";
            user2 = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
