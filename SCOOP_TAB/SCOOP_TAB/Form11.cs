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
    public partial class Form11 : Form
    {
        public static int paid = 0;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form11()
        {
            InitializeComponent();
            check();
            BindGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Form3.v;
            //int y = Form5.v;
            int z = Form6.v;
            if (x == 1)
            {
                Form3.v = 0;
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }
            else if (z == 1)
            {
                Form6.v = 0;
                this.Hide();
                Form6 f6 = new Form6();
                f6.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox11.Text= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[4].Value);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ResetContro();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int x = Form6.r;
            if (x==1)
            {
                if (paid == 1)
                {
                    if (textBox4.Text != "" && textBox5.Text != "")
                    {
                        SqlConnection con = new SqlConnection(cs);
                        string query = "insert into temp_order values(@buyer,@item_code,@item_name,@quantity,@location,@img)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@buyer", textBox7.Text);
                        cmd.Parameters.AddWithValue("@item_code", textBox1.Text);
                        cmd.Parameters.AddWithValue("@item_name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@quantity", textBox4.Text);
                        cmd.Parameters.AddWithValue("@location", textBox5.Text);
                        cmd.Parameters.AddWithValue("@img", SavePhoto());

                        con.Open();
                        int a2 = cmd.ExecuteNonQuery();
                        if (a2 > 0)
                        {
                            MessageBox.Show("Order placed Successfully ! ");
                            entry();
                            BindGridView();
                            ResetContro();
                            entry();
                        }
                        else
                        {
                            MessageBox.Show("Order was not placed! ");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Select an item to order! ");
                    }
                }
                else
                {
                    MessageBox.Show(" PLEASE PAY BILL TO CONFIRM ORDER! ");
                }
            }
            else
            {
                MessageBox.Show(" YOU CAN NOT ORDER! ");
            }

            
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }
        void ResetContro()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            pictureBox1.Image = Properties.Resources.no_item_image;
        }

        private void button4_Click(object sender, EventArgs e)
        {
                if (textBox4.Text != "" && textBox5.Text != "")
                {
                    int c = Convert.ToInt32(textBox4.Text);
                    int d = Convert.ToInt32(textBox11.Text);
                    if (d > c)
                    {
                        int x = Convert.ToInt32(textBox3.Text);
                        int y = Convert.ToInt32(textBox4.Text);
                        textBox6.Text = Convert.ToString(x * y);
                        label8.Visible = true;
                        textBox6.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show(" Item quantity not available ");
                    }
                }
                else
                {
                    MessageBox.Show("Fill up all the box");
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox6.Text !="")
            {
                /*SqlConnection con = new SqlConnection(cs);
                string query = "insert into ordered_tbl values(@contactno,@date,@item_name,@quantity,@cost)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@contactno", textBox10.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@item_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@quantity", textBox4.Text);
                cmd.Parameters.AddWithValue("@cost", textBox6.Text);*/
                paid = 1;
                MessageBox.Show("BILL PAID");
            }
            else
            {
                MessageBox.Show("Click on show cost button first !");
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        void entry()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into ordered_tbl values(@contactno,@date,@item_name,@quantity,@cost)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@contactno", textBox10.Text);
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@item_name", textBox2.Text);
            cmd.Parameters.AddWithValue("@quantity", textBox4.Text);
            cmd.Parameters.AddWithValue("@cost", textBox6.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                //MessageBox.Show("Data Inserted Successfully ! ");
                //BindGridView();
                //ResetContro();
            }
            else
            {
                //MessageBox.Show("Data not Inserted ! ");
            }
        }
        void check ()
        {
            int abc = Form3.v;
            if (abc==1)
            {
                textBox7.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label9.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                button2.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
            }
            else
            {
                textBox8.Text = Form6.user4;
                textBox9.Text = Form6.pass4;
                SqlConnection con = new SqlConnection(cs);
                string query = "select* from customer_tbl where username=@user and pass=@pass ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", textBox8.Text);
                cmd.Parameters.AddWithValue("@pass", textBox9.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox10.Text = dr.GetValue(0).ToString();
                    textBox7.Text = dr.GetValue(1).ToString();
                    textBox5.Text = dr.GetValue(4).ToString();
                }
                con.Close();
            }
        }
    }
}
