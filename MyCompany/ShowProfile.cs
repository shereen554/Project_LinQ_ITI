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
    public partial class ShowProfile : Form
    {
        string _userName;
        MyCompanyContext db;
        Employee employee;
        public ShowProfile(string UserName)
        {
            InitializeComponent();
            _userName = UserName;
            db = new MyCompanyContext();
        }

        private void ShowProfile_Load(object sender, EventArgs e)
        {
            employee = db.Employees.FirstOrDefault(n => n.UserName == _userName);
            if (employee == null)
            {
                MessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                lb_Name.Text = employee.Name;
                lb_userName.Text = employee.UserName;

            }

            var department = db.Departments.FirstOrDefault(n => n.Dnum == employee.Dno);
            if (department == null)
            {
                lb_Dept.Text = "You are not in any Department ";
            }
            else
            {
                lb_Dept.Text = department.Dname;
            }

            var supervisor = db.Employees.FirstOrDefault(n => n.SSN == employee.Superssn);
            if (supervisor == null)
            {
                lb_supervisor.Text = "You don't have a Supervisor yet";
            }
            else
            {
                lb_supervisor.Text = supervisor.Name;
            }

            var projectId = db.Works_Fors.Where(n => n.ESSn == employee.SSN).ToList();
            if (projectId.Any())
            {
                foreach (var item in projectId)
                {
                    var project = db.Projects.SingleOrDefault(n => n.PNum == item.Pno);
                    if (project != null)
                    {
                        cb_Project.Items.Add(project.Pname);
                    }

                }
            }
            // fill data of Employee

        }

        private void btn_Edit_profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfile editProfile = new EditProfile(_userName);
            editProfile.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login=new Login();
            login.ShowDialog();
        }
    }
}
