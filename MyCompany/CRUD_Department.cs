using Microsoft.EntityFrameworkCore;
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
    public partial class CRUD_Department : Form
    {
        MyCompanyContext db;
        int id;
        string _userName;
        public CRUD_Department(string username)
        {
            InitializeComponent();
            this._userName = username;
            db = new MyCompanyContext();
        }
        public void ShowDepartment()
        {
            dgv_Dept.DataSource = db.Departments.Select(n => new { n.Dnum, Department = n.Dname, Manager_Start = n.MGRStart_Date, n.MGRSSN, Manager = n.MGRSSNNavigation.Name }).ToList();
            dgv_Dept.Columns["Dnum"].Visible = false;
            dgv_Dept.Columns["MGRSSN"].Visible = false;

            cb_Manager.DataSource = db.Employees.Select(n => new { n.SSN, Manager = n.Name }).ToList();
            cb_Manager.ValueMember = "SSN";
            cb_Manager.DisplayMember = "Manager";
            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;
        }

        private void CRUD_Department_Load(object sender, EventArgs e)
        {
            ShowDepartment();
        }

        private void dgv_Dept_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_Dept.SelectedRows[0].Cells[0].Value;
            if (id <= 0)
            {
                MessageBox.Show(" Data Select Error !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Department = db.Departments.FirstOrDefault(n => n.Dnum == id);
            if (Department == null)
            {
                MessageBox.Show("Department Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txt_DeptName.Text = (string?)Department.Dname;
            dt_MangeStar.Value = (DateTime)Department.MGRStart_Date;

            if (Department.MGRSSN != null)
            {
                cb_Manager.SelectedValue = Department.MGRSSN;
            }
            else
            {
                MessageBox.Show("Department not Has Manager", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_DeptName.Text))
            {
                MessageBox.Show("Please fill All Data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Department department = new Department();
            department.Dname = txt_DeptName.Text;
            department.MGRStart_Date = dt_MangeStar.Value;
            department.MGRSSN = (int?)cb_Manager.SelectedValue;
            db.Departments.Add(department);
            db.SaveChanges();
            MessageBox.Show("Department Added Succesfuly ", "Informatio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowDepartment();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (id <= 0)
            {
                MessageBox.Show(" Data Select Error !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Dept = db.Departments.FirstOrDefault(n => n.Dnum == id);
            if (string.IsNullOrWhiteSpace(txt_DeptName.Text))
            {
                MessageBox.Show("Please fill All Data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dept.Dname = txt_DeptName.Text;
            Dept.MGRStart_Date = dt_MangeStar.Value;
            var manger = db.Departments.FirstOrDefault(n => n.MGRSSN == (int)cb_Manager.SelectedValue);
            if (manger != null)
            {
                MessageBox.Show(" Manager aready Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dept.MGRSSN = (int)cb_Manager.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Department Updated Succesfuly ", "Informatio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowDepartment();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (id <= 0)
            {
                MessageBox.Show("Selected Department !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var Dept = db.Departments.FirstOrDefault(n => n.Dnum == id);
            if (Dept == null)
            {
                MessageBox.Show(" Department Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var employees = db.Employees.Where(n => n.Dno == id).ToList();
            if (employees.Any())
            {
                MessageBox.Show("the Department has Employee ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                foreach (var emp in employees)
                {
                    emp.Dno = null;
                }
            }
            var projects = db.Projects.Where(n => n.Dnum == id).ToList();
            if (projects.Any())
            {
                MessageBox.Show("the Department has Projects ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                foreach (var project in projects)
                {
                    project.Dnum = null;
                }
            }
            db.Departments.Remove(Dept);
            db.SaveChanges();
            MessageBox.Show("Department Deleted Succesfuly ", "Informatio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowDepartment();

            ///=----------------------------------------------------

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dashBoard = new DashBoard(_userName);
            dashBoard.Show();
        }
    }
}
