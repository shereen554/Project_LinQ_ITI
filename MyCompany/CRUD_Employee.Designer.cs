namespace MyCompany
{
    partial class CRUD_Employee
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
            dgv_Employee = new DataGridView();
            btn_add = new Button();
            txt_Name = new TextBox();
            cb_Dept = new ComboBox();
            cb_Super = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            btn_update = new Button();
            btn_delete = new Button();
            label5 = new Label();
            label1 = new Label();
            txt_address = new TextBox();
            label6 = new Label();
            txt_salary = new TextBox();
            label7 = new Label();
            txt_gender = new TextBox();
            label3 = new Label();
            txt_username = new TextBox();
            lb_password = new Label();
            txt_Password = new TextBox();
            dt_BirthDate = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Employee).BeginInit();
            SuspendLayout();
            // 
            // dgv_Employee
            // 
            dgv_Employee.BackgroundColor = SystemColors.ControlLightLight;
            dgv_Employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Employee.Dock = DockStyle.Bottom;
            dgv_Employee.Location = new Point(0, 297);
            dgv_Employee.Name = "dgv_Employee";
            dgv_Employee.RowHeadersWidth = 62;
            dgv_Employee.Size = new Size(1131, 311);
            dgv_Employee.TabIndex = 0;
            dgv_Employee.RowHeaderMouseDoubleClick += dgv_Employee_RowHeaderMouseDoubleClick;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(629, 233);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(126, 42);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(163, 66);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(197, 31);
            txt_Name.TabIndex = 3;
            // 
            // cb_Dept
            // 
            cb_Dept.FormattingEnabled = true;
            cb_Dept.Location = new Point(917, 73);
            cb_Dept.Name = "cb_Dept";
            cb_Dept.Size = new Size(182, 33);
            cb_Dept.TabIndex = 4;
            // 
            // cb_Super
            // 
            cb_Super.FormattingEnabled = true;
            cb_Super.Location = new Point(917, 140);
            cb_Super.Name = "cb_Super";
            cb_Super.Size = new Size(182, 33);
            cb_Super.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(745, 66);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 6;
            label2.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(745, 141);
            label4.Name = "label4";
            label4.Size = new Size(130, 32);
            label4.TabIndex = 8;
            label4.Text = "SuperVisor";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(792, 233);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(126, 42);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(951, 229);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(126, 42);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(37, 65);
            label5.Name = "label5";
            label5.Size = new Size(80, 32);
            label5.TabIndex = 11;
            label5.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(37, 125);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 13;
            label1.Text = "Address";
            // 
            // txt_address
            // 
            txt_address.Location = new Point(163, 126);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(197, 31);
            txt_address.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(37, 179);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 15;
            label6.Text = "Salary";
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(163, 180);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(197, 31);
            txt_salary.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(37, 232);
            label7.Name = "label7";
            label7.Size = new Size(92, 32);
            label7.TabIndex = 17;
            label7.Text = "Gender";
            // 
            // txt_gender
            // 
            txt_gender.Location = new Point(163, 233);
            txt_gender.MaxLength = 1;
            txt_gender.Name = "txt_gender";
            txt_gender.Size = new Size(197, 31);
            txt_gender.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(384, 56);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 19;
            label3.Text = "User Name";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(525, 57);
            txt_username.MaxLength = 50;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(197, 31);
            txt_username.TabIndex = 18;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_password.ForeColor = SystemColors.Highlight;
            lb_password.Location = new Point(393, 119);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(116, 32);
            lb_password.TabIndex = 21;
            lb_password.Text = "Password";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(525, 118);
            txt_Password.MaxLength = 50;
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(197, 31);
            txt_Password.TabIndex = 20;
            // 
            // dt_BirthDate
            // 
            dt_BirthDate.Location = new Point(525, 171);
            dt_BirthDate.Name = "dt_BirthDate";
            dt_BirthDate.Size = new Size(197, 31);
            dt_BirthDate.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(393, 172);
            label9.Name = "label9";
            label9.Size = new Size(126, 32);
            label9.TabIndex = 23;
            label9.Text = "Birth Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(1084, 9);
            label8.Name = "label8";
            label8.Size = new Size(35, 38);
            label8.TabIndex = 24;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(0, -1);
            label10.Name = "label10";
            label10.Size = new Size(128, 38);
            label10.TabIndex = 25;
            label10.Text = "<-- back";
            label10.Click += label10_Click;
            // 
            // CRUD_Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1131, 608);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dt_BirthDate);
            Controls.Add(lb_password);
            Controls.Add(txt_Password);
            Controls.Add(label3);
            Controls.Add(txt_username);
            Controls.Add(label7);
            Controls.Add(txt_gender);
            Controls.Add(label6);
            Controls.Add(txt_salary);
            Controls.Add(label1);
            Controls.Add(txt_address);
            Controls.Add(label5);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cb_Super);
            Controls.Add(cb_Dept);
            Controls.Add(txt_Name);
            Controls.Add(btn_add);
            Controls.Add(dgv_Employee);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CRUD_Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD_Employee";
            Load += CRUD_Employee_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Employee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Employee;
        private Button btn_add;
        private TextBox txt_Name;
        private ComboBox cb_Dept;
        private ComboBox cb_Super;
        private Label label2;
        private Label label4;
        private Button btn_update;
        private Button btn_delete;
        private Label label5;
        private Label label1;
        private TextBox txt_address;
        private Label label6;
        private TextBox txt_salary;
        private Label label7;
        private TextBox txt_gender;
        private Label label3;
        private TextBox txt_username;
        private Label lb_password;
        private TextBox txt_Password;
        private DateTimePicker dt_BirthDate;
        private Label label9;
        private Label label8;
        private Label label10;
    }
}