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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            Database db = new Database();
            try
            {
                dtManagers.DataSource = db.Managers.GetAllManagers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form3 f3 = new Form3();
            f3.Show();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatedName = tbName.Text;
            string updatedAddress = tbAddress.Text;
            string updatedSalary = tbSalary.Text;
            Manager mng = new Manager();

            mng.UserName = tbUname.Text;
            mng.Name = tbName.Text;
            mng.Address = tbAddress.Text;
            mng.Salary = tbSalary.Text;

            Database db = new Database();
            bool rs = db.Managers.Update(mng);
            if (rs)
            {
                dtManagers.DataSource = db.Managers.GetAllManagers();
                MessageBox.Show("Updated");

            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = tbUname.Text;
            Database db = new Database();
            bool rs = db.Managers.Delete(username);
            if (rs)
            {
                dtManagers.DataSource = db.Managers.GetAllManagers();
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string uname = tbUname.Text;
            Database db = new Database();
            Manager mng = db.Managers.Search(uname);
            if (mng == null)
            {
                MessageBox.Show("Employee not found");
                tbName.Text = "";
                tbAddress.Text = "";
            }
            else
            {
                tbName.Text = mng.Name;
                tbAddress.Text = mng.Address;
                tbSalary.Text = mng.Salary;
            }
        }
    }
}
