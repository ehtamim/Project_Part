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
    public partial class Form13 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form13()
        {
            InitializeComponent();
            BindGridView();
            BindGridView1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetContro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "delete from temp_order where item_code=@item_code";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@item_code", textBox2.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a >= 0)
                {
                    MessageBox.Show("Item served Successfully ! ");
                    BindGridView1();
                    //ResetContro();
                }
                else
                {
                    MessageBox.Show("Item was not served ! ");
                }
            }
            else
            {
                MessageBox.Show("CHOOSE AN ITEM TO SERVE !");
            }
            if(textBox1.Text != "")
            {
                available();
                SqlConnection con1 = new SqlConnection(cs);
                string query1 = "update item_tbl set available=@avail where code=@item_code";
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                cmd1.Parameters.AddWithValue("@item_code", textBox2.Text);
                cmd1.Parameters.AddWithValue("@avail", textBox7.Text);
                con1.Open();
                int a = cmd1.ExecuteNonQuery();
                if (a >= 0)
                {
                    BindGridView();
                    ResetContro();
                }
            }
        }
        void ResetContro()
        {
            textBox1.Clear();
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select code,name,available,price,pic from item_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[4];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
        }
        void BindGridView1()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from temp_order";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView2.DataSource = data;
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView2.Columns[5];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.RowTemplate.Height = 50;
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }
        void available()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select* from item_tbl where code=@code ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@code", textBox2.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox6.Text = dr.GetValue(3).ToString();
            }
            con.Close();
            int b = Convert.ToInt32(textBox6.Text);
            int c = Convert.ToInt32(textBox4.Text);
            textBox7.Text =Convert.ToString(b - c);
        }
    }
}
