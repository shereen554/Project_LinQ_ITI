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
    public partial class EditProfile : Form
    {
        Employee employee;
        MyCompanyContext db;
        string _username;

        public EditProfile(string username)
        {
            InitializeComponent();
            this._username = username;

            db = new MyCompanyContext();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            if (_username == null)
            {
                MessageBox.Show("the Employee Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            employee = db.Employees.FirstOrDefault(n => n.UserName == _username);
            if (employee == null)
            {
                MessageBox.Show("the Employee Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txt_Name.Text = employee.Name;
            txt_Address.Text = employee.Address;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text) ||
              string.IsNullOrWhiteSpace(txt_Address.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txt_Password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txt_Name.Text.Length <= 3)
            {
                MessageBox.Show("Name must be at least 3 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            employee.Name = txt_Name.Text;
            employee.Address = txt_Address.Text;
            db.SaveChanges();

            MessageBox.Show("Update Data !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_Address.Text = txt_Name.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txt_Password.Text.Length <= 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (employee.Passowrd == txt_OldPassword.Text)
            {
                employee.Passowrd = txt_Password.Text;
                db.SaveChanges();

                MessageBox.Show("Update Password!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Password.Text = txt_OldPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Password Is Not Correct", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = txt_OldPassword.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowProfile showProfile = new ShowProfile(_username);
            showProfile.ShowDialog();

        }
    }
}
