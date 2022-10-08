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
    public partial class Form12 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form12()
        {
            InitializeComponent();
            check();
            BindGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Form3.v;
            if (x==0)
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into review_tbl values(@name,@review)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@review", numericUpDown1.Value);

                con.Open();
                int a = cmd.ExecuteNonQuery();//0 1
                if (a > 0)
                {
                    MessageBox.Show(" Thanks for your review ! ");
                    BindGridView();
                    ResetContro();
                }
                else
                {
                    MessageBox.Show(" Review was not given ! ");
                }
            }
            else
            {
                MessageBox.Show(" OWNER CAN'T GIVE REVIEW ");
            }

        }
        void ResetContro()
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from review_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Form3.v;
            int z = Form6.v;
            if (x == 1)
            {
                Form3.v = 0;
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
            {
                Form6.v = 0;
                this.Hide();
                Form6 f6 = new Form6();
                f6.Show();
            }
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            if (numericUpDown1.Value==0)
            {
                numericUpDown1.Focus();
                errorProvider1.SetError(this.numericUpDown1, "Give a review please");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        void check()
        {
            int x = Form3.v;
            if (x == 1)
            {
                //textBox1.Text = Form3.name1;
            }
            else
            {
                textBox2.Text = Form6.user4;
                textBox3.Text = Form6.pass4;
                SqlConnection con = new SqlConnection(cs);
                string query = "select* from customer_tbl where username=@user and pass=@pass ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", textBox2.Text);
                cmd.Parameters.AddWithValue("@pass", textBox3.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = dr.GetValue(1).ToString();
                }
                con.Close();
            }
        }
    }
}
