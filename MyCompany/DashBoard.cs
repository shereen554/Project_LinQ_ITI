using MyCompany.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCompany
{
    public partial class DashBoard : Form
    {
        string _UserName;
        MyCompanyContext db;
        Employee employee;
        public DashBoard(string UserName)
        {
            InitializeComponent();
            _UserName = UserName;
            db = new MyCompanyContext();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfile editProfile = new EditProfile(employee);
            editProfile.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            var employee = db.Employees.FirstOrDefault(n => n.UserName == _UserName);
            if (employee == null)
            {
                MessageBox.Show("Your Account not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lb_Name.Text = employee.Name;

        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Employee cRUD_Employee = new CRUD_Employee();
            cRUD_Employee.Show();
        }

        private void btn_Project_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Project cRUD_Project = new CRUD_Project();
            cRUD_Project.Show();
        }
    }
}
