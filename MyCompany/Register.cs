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
    public partial class Register : Form
    {
        Employee Employee;
        MyCompanyContext db;
        public Register()
        {
            InitializeComponent();
            db = new MyCompanyContext();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txt_name.Text) ||
                string.IsNullOrWhiteSpace(txt_userName.Text) ||
                string.IsNullOrWhiteSpace(txt_address.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isUserNameTaken = db.Employees.Any(e => e.UserName == txt_userName.Text);
            if (isUserNameTaken)
            {
                MessageBox.Show("The username is already taken. Please choose a different one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char gender = '_';
            if (rb_Male.Checked)
            {
                gender = 'M';
            }
            else if (rb_femail.Checked)
            {
                gender = 'F';
            }
            else
            {
                MessageBox.Show("Please select a gender.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Employee employee = new Employee
            {
                Name = txt_name.Text,
                UserName = txt_userName.Text,
                Address = txt_address.Text,
                BirthDate = dt_birthDate.Value,
                Passowrd = txt_password.Text,
                Gender = gender,
                Role = "User"
            };

            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();

                MessageBox.Show("Employee data has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }
    }
}
