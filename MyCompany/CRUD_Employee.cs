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

    public partial class CRUD_Employee : Form
    {
        MyCompanyContext db;
        int id;
        string _UserName;
        public CRUD_Employee(string username)
        {
            InitializeComponent();
            this._UserName = username;
            db = new MyCompanyContext();
        }
        public void ShowEmployee()
        {
            dgv_Employee.DataSource = db.Employees.Where(n => n.Role == "User").Select(n => new { n.SSN, n.Name, n.UserName, n.BirthDate, n.Gender,n.Address,n.Phone,n.Email, n.Salary, n.Dno, n.Superssn, n.Role, Department = n.DnoNavigation.Dname, SuperVisor = n.SuperssnNavigation.Name }).ToList();
            dgv_Employee.Columns["Role"].Visible = false;
            dgv_Employee.Columns["Superssn"].Visible = false;
            dgv_Employee.Columns["Dno"].Visible = false;
            dgv_Employee.Columns["SSN"].Visible = false;
            // Super Visor 
            cb_Super.DataSource = db.Employees.ToList();
            cb_Super.ValueMember = "SSN";
            cb_Super.DisplayMember = "Name";
            cb_Dept.DataSource = db.Departments.ToList();
            cb_Dept.ValueMember = "Dnum";
            cb_Dept.DisplayMember = "Dname";
            txt_address.Text = txt_gender.Text = txt_Name.Text = txt_Password.Text = txt_salary.Text = txt_username.Text=txt_Email.Text=txt_Phone.Text = "";


        }

        private void CRUD_Employee_Load(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_Name.Text) ||
                string.IsNullOrWhiteSpace(txt_salary.Text) ||
                string.IsNullOrWhiteSpace(txt_address.Text) ||
                string.IsNullOrWhiteSpace(txt_gender.Text) ||
                string.IsNullOrWhiteSpace(txt_username.Text) ||
                string.IsNullOrWhiteSpace(txt_Password.Text) ||
                cb_Dept.SelectedValue == null ||
                cb_Super.SelectedValue == null)
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(txt_salary.Text, out int salary))
            {
                MessageBox.Show("Salary must be a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (txt_gender.Text != "F" && txt_gender.Text != "M")
            {
                MessageBox.Show("Gender must be a single character (M or F)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(cb_Dept.SelectedValue is int departmentId) || !(cb_Super.SelectedValue is int superSsn))
            {
                MessageBox.Show("Please select a valid Department and Supervisor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            Employee employee = new Employee
            {
                Name = txt_Name.Text,
                Salary = (int?)salary,
                Address = txt_address.Text,
                Gender = char.Parse(txt_gender.Text),
                BirthDate = dt_BirthDate.Value,
                Role = "User",
                UserName = txt_username.Text,
                Dno = departmentId,
                Superssn = superSsn,
                Passowrd = txt_Password.Text,
                Email=txt_Email.Text,
                Phone=txt_Phone.Text
            };

            db.Employees.Add(employee);
            db.SaveChanges();

            MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowEmployee();

        }

        private void dgv_Employee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_Employee.SelectedRows[0].Cells["SSN"].Value;
            Employee emp = db.Employees.Where(n => n.SSN == id).FirstOrDefault();
            txt_address.Text = emp.Address;
            txt_gender.Text = emp.Gender.ToString();
            txt_Name.Text = emp.Name;
            txt_salary.Text = emp.Salary.ToString();
            txt_username.Text = emp.UserName;
            txt_Phone.Text = emp.Phone.ToString();
            txt_Email.Text = emp.Email.ToString();
            //txt_Password.Visible = false;
            lb_password.Visible = true;
            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
            //lb_password.Visible=true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text) ||
               string.IsNullOrWhiteSpace(txt_salary.Text) ||
               string.IsNullOrWhiteSpace(txt_address.Text) ||
               string.IsNullOrWhiteSpace(txt_gender.Text) ||
               string.IsNullOrWhiteSpace(txt_username.Text) ||
               cb_Dept.SelectedValue == null ||
               cb_Super.SelectedValue == null)
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_gender.Text != "F" && txt_gender.Text != "M")
            {
                MessageBox.Show("Gender must be a single character (M or F)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(txt_salary.Text, out int salary))
            {
                MessageBox.Show("Salary must be a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!(cb_Dept.SelectedValue is int departmentId) || !(cb_Super.SelectedValue is int superSsn))
            {
                MessageBox.Show("Please select a valid Department and Supervisor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            Employee emp = db.Employees.FirstOrDefault(n => n.SSN == id);
            if (emp != null)
            {
                emp.Name = txt_Name.Text;
                emp.Salary = salary;
                emp.Superssn = superSsn;
                emp.Dno = departmentId;
                emp.Address = txt_address.Text;
                emp.BirthDate = dt_BirthDate.Value;
                emp.Gender = char.Parse(txt_gender.Text);
                emp.UserName = txt_username.Text;
                emp.Email = email;
                emp.Phone=phoneNumber;
                
                db.SaveChanges();
                MessageBox.Show("Employee Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowEmployee();
                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_update.Visible = false;
            }
            else
            {
                MessageBox.Show("Employee Not Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                Employee employee = db.Employees.FirstOrDefault(n => n.SSN == id);
                if (employee != null)
                {
                    db.Employees.Remove(employee);
                    db.SaveChanges();
                    MessageBox.Show("Employee Deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowEmployee();

                    btn_add.Visible = true;
                    btn_delete.Visible = false;
                    btn_update.Visible = false;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dash = new DashBoard(_UserName);
            dash.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }
    }
}
