using Microsoft.EntityFrameworkCore.Design;
using MyCompany.Models;

namespace MyCompany
{
    public partial class Login : Form
    {
        MyCompanyContext db;
        public Login()
        {
            InitializeComponent();
            db = new MyCompanyContext();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_userName.Text) || string.IsNullOrWhiteSpace(txt_passowrd.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var employee = db.Employees.SingleOrDefault(n => n.UserName == txt_userName.Text && n.Passowrd == txt_passowrd.Text);

            if (employee != null)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(employee.Role=="User")
                {
                    this.Hide();
                    ShowProfile showProfile = new ShowProfile(txt_userName.Text);
                    showProfile.ShowDialog();
                }
                else
                {
                    this.Hide();
                    DashBoard dashBoard=new DashBoard(txt_userName.Text);
                    dashBoard.ShowDialog(); 
                }
                // Redirect user to their profile page

            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_passowrd.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }
    }
}
