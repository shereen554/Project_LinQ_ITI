namespace MyCompany
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lb_Name = new Label();
            btn_Employee = new Button();
            btn_Project = new Button();
            btn_Department = new Button();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Person;
            pictureBox1.Location = new Point(28, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_Name.ForeColor = SystemColors.Highlight;
            lb_Name.Location = new Point(54, 273);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(94, 38);
            lb_Name.TabIndex = 1;
            lb_Name.Text = "Name";
            // 
            // btn_Employee
            // 
            btn_Employee.BackColor = SystemColors.HighlightText;
            btn_Employee.Font = new Font("Segoe UI", 22F, FontStyle.Bold | FontStyle.Italic);
            btn_Employee.ForeColor = SystemColors.Highlight;
            btn_Employee.Location = new Point(675, 63);
            btn_Employee.Name = "btn_Employee";
            btn_Employee.Size = new Size(290, 258);
            btn_Employee.TabIndex = 2;
            btn_Employee.Text = "Employee";
            btn_Employee.UseVisualStyleBackColor = false;
            btn_Employee.Click += btn_Employee_Click;
            // 
            // btn_Project
            // 
            btn_Project.BackColor = SystemColors.HighlightText;
            btn_Project.Font = new Font("Segoe UI", 22F, FontStyle.Bold | FontStyle.Italic);
            btn_Project.ForeColor = SystemColors.Highlight;
            btn_Project.Location = new Point(322, 63);
            btn_Project.Name = "btn_Project";
            btn_Project.Size = new Size(290, 258);
            btn_Project.TabIndex = 3;
            btn_Project.Text = "Project";
            btn_Project.UseVisualStyleBackColor = false;
            btn_Project.Click += btn_Project_Click;
            // 
            // btn_Department
            // 
            btn_Department.BackColor = SystemColors.HighlightText;
            btn_Department.Font = new Font("Segoe UI", 22F, FontStyle.Bold | FontStyle.Italic);
            btn_Department.ForeColor = SystemColors.Highlight;
            btn_Department.Location = new Point(511, 343);
            btn_Department.Name = "btn_Department";
            btn_Department.Size = new Size(290, 258);
            btn_Department.TabIndex = 4;
            btn_Department.Text = "Department";
            btn_Department.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(1033, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 38);
            label1.TabIndex = 5;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(28, 453);
            button1.Name = "button1";
            button1.Size = new Size(186, 50);
            button1.TabIndex = 6;
            button1.Text = "Edit Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1090, 624);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btn_Department);
            Controls.Add(btn_Project);
            Controls.Add(btn_Employee);
            Controls.Add(lb_Name);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoard";
            Text = "DashBoard";
            Load += DashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_Name;
        private Button btn_Employee;
        private Button btn_Project;
        private Button btn_Department;
        private Label label1;
        private Button button1;
    }
}