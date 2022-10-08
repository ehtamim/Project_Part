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
    public partial class Form3 : Form
    {
        public static int v = 0,a=0,fo=0,r=0;
        int mou=0;
        public static string name1,pass1,loc1,user1;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form3()
        {
            InitializeComponent();
            Check();
        }
        void Check()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select* from owner_tbl where username=@user and pass=@pass ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", Form3.user1);
            cmd.Parameters.AddWithValue("@pass", Form3.pass1);
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
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 f18 = new Form18();
            f18.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 f17 = new Form17();
            f17.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reset1();
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
            pictureBox3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            linkLabel1.Visible = true;
            button7.Visible = true;
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
                button7.Visible = false;
            }
        }

        private void Form3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
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
            button7.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            a = 1;
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
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
            button7.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mou = 1;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            label3.Visible = true;
            pictureBox3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            linkLabel1.Visible = true;
            button7.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 f16 = new Form16();
            f16.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v = 1;
            this.Hide();
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //r = 1;
            v = 1;
            this.Hide();
            Form12 f12 = new Form12();
            f12.Show();
        }
        void Reset1()
        {
            v = 0;
            r = 0;
            a = 0;
            name1 = "";
            pass1 = "";
            loc1 = "";
            user1 = "";
        }
    }
}
