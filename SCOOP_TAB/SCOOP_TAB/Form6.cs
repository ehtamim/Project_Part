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
    public partial class Form6 : Form
    {
        public static string name4, pass4,loc4,user4;
        public static int v = 0;
        public static int r = 0;
        public static int z = 0;
        int mou;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form6()
        {
            InitializeComponent();
            change();
            Check();
        }

        void Check()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select* from customer_tbl where username=@user and pass=@pass ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", Form6.user4);
            cmd.Parameters.AddWithValue("@pass", Form6.pass4);
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
        void change()
        {
            pictureBox1.Image = Properties.Resources.Chocobar;
            timer5.Enabled = false;
            timer1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            v = 1;
            r = 1;
            this.Hide();
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r = 1;
            z = 1;
            this.Hide();
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image =Properties.Resources.Crunchy;
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Malai;
            timer2.Enabled = false;
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Robusto_C;
            timer3.Enabled = false;
            timer4.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Two_1;
            timer4.Enabled = false;
            timer5.Enabled = true;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            change();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            v = 1;
            r = 1;
            this.Hide();
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mou = 1;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
            label3.Visible = true;
            pictureBox3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            linkLabel1.Visible = true;
            button3.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void Form6_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form6_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
            pictureBox3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            linkLabel1.Visible = true;
            button3.Visible = true;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (mou==1)
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
                button3.Visible = false;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mou = 0;
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
            label3.Visible = false;
            pictureBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            linkLabel1.Visible = false;
            button3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset4();
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form6_MouseClick(object sender, MouseEventArgs e)
        {
            mou = 0;
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
            label3.Visible = false;
            pictureBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            linkLabel1.Visible = false;
            button3.Visible = false;
        }

        void Reset4()
        {
            v = 0;
            r = 0;
            name4 = "";
            pass4 = "";
            loc4= "";
            user4 = "";
        }
    }
}
