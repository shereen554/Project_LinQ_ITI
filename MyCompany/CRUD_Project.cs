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
    public partial class CRUD_Project : Form
    {
        MyCompanyContext db;
        int id;
        public CRUD_Project()
        {
            InitializeComponent();
            db = new MyCompanyContext();
        }
        public void ShowProject()
        {
            dgv_Project.DataSource = db.Projects.Select(n => new { n.PNum, ProjectName = n.Pname, Project_Location = n.Plocation, n.Dnum, Department = n.DnumNavigation.Dname }).ToList();
            dgv_Project.Columns["PNum"].Visible = false;
            dgv_Project.Columns["Dnum"].Visible = false;

            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            cb_Dept.DataSource = db.Departments.ToList();
            cb_Dept.ValueMember = "Dnum";
            cb_Dept.DisplayMember = "Dname";
            txt_PLocation.Text = txt_PName.Text = "";

        }
        private void CRUD_Project_Load(object sender, EventArgs e)
        {
            ShowProject();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_PName.Text) || string.IsNullOrWhiteSpace(txt_PLocation.Text))
            {
                MessageBox.Show("Please fill All Data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Project project = new Project();
            project.Pname = txt_PName.Text;
            project.Plocation = txt_PLocation.Text;
            project.Dnum = (int?)cb_Dept.SelectedValue;
            db.Projects.Add(project);
            db.SaveChanges();
            MessageBox.Show("Project Added Succesfuly ", "Informatio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowProject();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (id <= 0)
            {
                MessageBox.Show(" Data Select Error !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var project = db.Projects.FirstOrDefault(n => n.PNum == id);
            if (string.IsNullOrWhiteSpace(txt_PLocation.Text) || string.IsNullOrWhiteSpace(txt_PName.Text))
            {
                MessageBox.Show("Please fill All Data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            project.Pname = txt_PName.Text;
            project.Plocation = txt_PLocation.Text;
            project.Dnum = (int)cb_Dept.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Project Updated Succesfuly ", "Informatio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowProject();
        }

        private void dgv_Project_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_Project.SelectedRows[0].Cells["PNum"].Value;
            if (id <= 0)
            {
                MessageBox.Show("Selected Project !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var project = db.Projects.FirstOrDefault(n => n.PNum == id);
            if (project == null)
            {
                MessageBox.Show("Project Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            txt_PLocation.Text = (string?)project.Plocation;
            txt_PName.Text = (string?)project.Pname;
            if (cb_Dept.DataSource != null && project.Dnum != null)
            {
                cb_Dept.SelectedValue = project.Dnum;
            }
            else
            {
                MessageBox.Show("Project not Has Department", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (id <= 0)
            {
                MessageBox.Show("Selected Project !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var project = db.Projects.FirstOrDefault(n => n.PNum == id);
            if (project == null) 
            {
                MessageBox.Show(" Project Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.Projects.Remove(project);
            db.SaveChanges();
            MessageBox.Show("Project Deleted Succesfuly ", "Informatio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowProject();

        }
    }
}
