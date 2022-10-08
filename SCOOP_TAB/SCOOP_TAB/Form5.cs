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
    public partial class Form5 : Form
    {
        public static string name3, pass3,loc3,user3;
        public static int v = 0;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        int mou = 0;
        public Form5()
        {
            InitializeComponent();
            Check();
        }
        void Check()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select* from employee_tbl where username=@user and pass=@pass ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", Form5.user3);
            cmd.Parameters.AddWithValue("@pass", Form5.pass3);
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
        private void button2_Click(object sender, EventArgs e)
        {
            
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form14 f14 = new Form14();
            f14.Show();
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
            button4.Visible = true;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
            pictureBox3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            linkLabel1.Visible = true;
            button4.Visible = true;
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
                button4.Visible = false;
            }
        }

        private void Form5_MouseClick(object sender, MouseEventArgs e)
        {
            mou = 0;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            label3.Visible = false;
            pictureBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            linkLabel1.Visible = false;
            button4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mou = 0;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            label3.Visible = false;
            pictureBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            linkLabel1.Visible = false;
            button4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reset3();
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v = 1;
            this.Hide();
            Form13 f13 = new Form13();
            f13.Show();
        }
        void Reset3()
        {
            v = 0;
            name3 = "";
            pass3 = "";
            loc3= "";
            user3 = "";
        }
    }
}
