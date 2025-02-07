using MyCompany.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            txt_Email.Text = employee.Email;
            txt_Phone.Text = employee.Phone;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text) ||
              string.IsNullOrWhiteSpace(txt_Address.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txt_Name.Text.Length <= 3)
            {
                MessageBox.Show("Name must be at least 3 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = txt_Email.Text.Trim();
            if (IsValidEmail(email))
            {
                lblResult.Text = "Email is valid ✅";
                lblResult.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblResult.Text = "Email is invalid ❌";
                lblResult.ForeColor = System.Drawing.Color.Red;
                return;
            }
            string phoneNumber = txt_Phone.Text.Trim();
            if (IsValidEgyptianPhone(phoneNumber))
            {
                lblResultPhone.Text = "Phone is valid ✅ ";
                lblResultPhone.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResultPhone.Text = "Phone is invalid ❌";
                lblResultPhone.ForeColor = System.Drawing.Color.Red;
                return;
            }

            employee.Name = txt_Name.Text;
            employee.Address = txt_Address.Text;
            db.SaveChanges();

            MessageBox.Show("Update Data !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_Address.Text = txt_Name.Text = txt_Email.Text=txt_Phone.Text="";
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private bool IsValidEgyptianPhone(string phoneNumber)
        {
            string pattern = @"^(010|011|012|015)\d{8}$";
            return Regex.IsMatch(phoneNumber, pattern);
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
            if(employee.Role=="User")
            {
                this.Hide();
                ShowProfile showProfile = new ShowProfile(_username);
                showProfile.ShowDialog();
            }
            else
            {
                this.Hide();
                DashBoard dashBoard= new DashBoard();
                dashBoard.ShowDialog();
            }


        }
    }
}
