using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Entities;

namespace Hospital_Management_System
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            Database db = new Database();
            try
            {
                dataGridView1.DataSource = db.Reviews.GetAllReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
