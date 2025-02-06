namespace MyCompany
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            txt_userName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_password = new TextBox();
            label3 = new Label();
            txt_name = new TextBox();
            label4 = new Label();
            txt_address = new TextBox();
            label5 = new Label();
            dt_birthDate = new DateTimePicker();
            rb_Male = new RadioButton();
            rb_femail = new RadioButton();
            label6 = new Label();
            btn_register = new Button();
            label7 = new Label();
            panel1 = new Panel();
            lblResult = new Label();
            label10 = new Label();
            label9 = new Label();
            txt_Phone = new TextBox();
            txt_Email = new TextBox();
            login_showPass = new CheckBox();
            linkLabel1 = new LinkLabel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            lblResultPhone = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_userName
            // 
            txt_userName.ForeColor = SystemColors.Highlight;
            txt_userName.Location = new Point(187, 71);
            txt_userName.Multiline = true;
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(234, 37);
            txt_userName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(55, 70);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 1;
            label1.Text = "User Nme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(57, 188);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.ForeColor = SystemColors.Highlight;
            txt_password.Location = new Point(187, 188);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(234, 37);
            txt_password.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(94, 128);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.ForeColor = SystemColors.Highlight;
            txt_name.Location = new Point(187, 129);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(234, 37);
            txt_name.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(75, 422);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 7;
            label4.Text = "Address";
            // 
            // txt_address
            // 
            txt_address.ForeColor = SystemColors.Highlight;
            txt_address.Location = new Point(187, 423);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(234, 37);
            txt_address.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(50, 483);
            label5.Name = "label5";
            label5.Size = new Size(119, 30);
            label5.TabIndex = 9;
            label5.Text = "Birth Date";
            // 
            // dt_birthDate
            // 
            dt_birthDate.Location = new Point(187, 481);
            dt_birthDate.Name = "dt_birthDate";
            dt_birthDate.Size = new Size(234, 31);
            dt_birthDate.TabIndex = 10;
            // 
            // rb_Male
            // 
            rb_Male.AutoSize = true;
            rb_Male.ForeColor = SystemColors.Highlight;
            rb_Male.Location = new Point(205, 532);
            rb_Male.Name = "rb_Male";
            rb_Male.Size = new Size(76, 29);
            rb_Male.TabIndex = 11;
            rb_Male.TabStop = true;
            rb_Male.Text = "Male";
            rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_femail
            // 
            rb_femail.AutoSize = true;
            rb_femail.ForeColor = SystemColors.Highlight;
            rb_femail.Location = new Point(311, 532);
            rb_femail.Name = "rb_femail";
            rb_femail.Size = new Size(90, 29);
            rb_femail.TabIndex = 12;
            rb_femail.TabStop = true;
            rb_femail.Text = "Femail";
            rb_femail.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(83, 532);
            label6.Name = "label6";
            label6.Size = new Size(86, 30);
            label6.TabIndex = 13;
            label6.Text = "Gender";
            // 
            // btn_register
            // 
            btn_register.BackColor = SystemColors.Highlight;
            btn_register.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(187, 568);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(140, 46);
            btn_register.TabIndex = 14;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(165, 9);
            label7.Name = "label7";
            label7.Size = new Size(172, 38);
            label7.TabIndex = 15;
            label7.Text = "Register \U0001fa75";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblResultPhone);
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txt_Phone);
            panel1.Controls.Add(txt_Email);
            panel1.Controls.Add(login_showPass);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_userName);
            panel1.Controls.Add(btn_register);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(rb_femail);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(rb_Male);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dt_birthDate);
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(462, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 654);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(266, 311);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(83, 357);
            label10.Name = "label10";
            label10.Size = new Size(76, 30);
            label10.TabIndex = 21;
            label10.Text = "phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(83, 278);
            label9.Name = "label9";
            label9.Size = new Size(72, 30);
            label9.TabIndex = 20;
            label9.Text = "Email";
            // 
            // txt_Phone
            // 
            txt_Phone.ForeColor = SystemColors.Highlight;
            txt_Phone.Location = new Point(187, 350);
            txt_Phone.Multiline = true;
            txt_Phone.Name = "txt_Phone";
            txt_Phone.PasswordChar = '*';
            txt_Phone.Size = new Size(234, 37);
            txt_Phone.TabIndex = 19;
            // 
            // txt_Email
            // 
            txt_Email.ForeColor = SystemColors.Highlight;
            txt_Email.Location = new Point(187, 271);
            txt_Email.Multiline = true;
            txt_Email.Name = "txt_Email";
            txt_Email.PasswordChar = '*';
            txt_Email.Size = new Size(234, 37);
            txt_Email.TabIndex = 18;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.ForeColor = SystemColors.HotTrack;
            login_showPass.Location = new Point(196, 237);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(80, 29);
            login_showPass.TabIndex = 17;
            login_showPass.Text = "Show";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = SystemColors.ActiveCaption;
            linkLabel1.LinkColor = SystemColors.MenuHighlight;
            linkLabel1.Location = new Point(165, 617);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(212, 25);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Do you have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(977, 9);
            label8.Name = "label8";
            label8.Size = new Size(40, 42);
            label8.TabIndex = 17;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblResultPhone
            // 
            lblResultPhone.AutoSize = true;
            lblResultPhone.Location = new Point(271, 393);
            lblResultPhone.Name = "lblResultPhone";
            lblResultPhone.Size = new Size(0, 25);
            lblResultPhone.TabIndex = 23;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.programming_background4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1078, 725);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "password";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_userName;
        private Label label1;
        private Label label2;
        private TextBox txt_password;
        private Label label3;
        private TextBox txt_name;
        private Label label4;
        private TextBox txt_address;
        private Label label5;
        private DateTimePicker dt_birthDate;
        private RadioButton rb_Male;
        private RadioButton rb_femail;
        private Label label6;
        private Button btn_register;
        private Label label7;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label label8;
        private PictureBox pictureBox1;
        private CheckBox login_showPass;
        private Label label10;
        private Label label9;
        private TextBox txt_Phone;
        private TextBox txt_Email;
        private Label lblResult;
        private Label lblResultPhone;
    }
}