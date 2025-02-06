namespace MyCompany
{
    partial class EditProfile
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
            label1 = new Label();
            txt_Name = new TextBox();
            txt_Password = new TextBox();
            label2 = new Label();
            txt_Address = new TextBox();
            label3 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            button1 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            txt_OldPassword = new TextBox();
            label4 = new Label();
            button2 = new Button();
            panel2 = new Panel();
            login_showPass = new CheckBox();
            label5 = new Label();
            X = new Label();
            pictureBox1 = new PictureBox();
            btn_LogOut = new Button();
            txt_Phone = new TextBox();
            label7 = new Label();
            txt_Email = new TextBox();
            label8 = new Label();
            lblResultPhone = new Label();
            lblResult = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(42, 79);
            label1.Name = "label1";
            label1.Size = new Size(94, 38);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(164, 73);
            txt_Name.Multiline = true;
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(225, 44);
            txt_Name.TabIndex = 1;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(212, 99);
            txt_Password.Multiline = true;
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(225, 46);
            txt_Password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(30, 101);
            label2.Name = "label2";
            label2.Size = new Size(138, 38);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(164, 131);
            txt_Address.Multiline = true;
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(225, 41);
            txt_Address.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(19, 134);
            label3.Name = "label3";
            label3.Size = new Size(117, 38);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(105, 351);
            button1.Name = "button1";
            button1.Size = new Size(265, 58);
            button1.TabIndex = 6;
            button1.Text = "Save Change";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(lblResultPhone);
            panel1.Controls.Add(txt_Email);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_Phone);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txt_Name);
            panel1.Controls.Add(txt_Address);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(649, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 423);
            panel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(134, 22);
            label6.Name = "label6";
            label6.Size = new Size(202, 37);
            label6.TabIndex = 12;
            label6.Text = "Change Data";
            // 
            // txt_OldPassword
            // 
            txt_OldPassword.Location = new Point(212, 204);
            txt_OldPassword.Multiline = true;
            txt_OldPassword.Name = "txt_OldPassword";
            txt_OldPassword.PasswordChar = '*';
            txt_OldPassword.Size = new Size(225, 41);
            txt_OldPassword.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(8, 207);
            label4.Name = "label4";
            label4.Size = new Size(191, 38);
            label4.TabIndex = 8;
            label4.Text = "Old Password";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(130, 317);
            button2.Name = "button2";
            button2.Size = new Size(187, 51);
            button2.TabIndex = 10;
            button2.Text = "Save Passowrd";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(login_showPass);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(txt_Password);
            panel2.Controls.Add(txt_OldPassword);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(62, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 423);
            panel2.TabIndex = 11;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.ForeColor = SystemColors.HotTrack;
            login_showPass.Location = new Point(219, 273);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(82, 29);
            login_showPass.TabIndex = 12;
            login_showPass.Text = "Show";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(80, 13);
            label5.Name = "label5";
            label5.Size = new Size(263, 37);
            label5.TabIndex = 11;
            label5.Text = "Change Passeord";
            // 
            // X
            // 
            X.AutoSize = true;
            X.BackColor = Color.Transparent;
            X.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X.ForeColor = SystemColors.Highlight;
            X.Location = new Point(1090, 9);
            X.Name = "X";
            X.Size = new Size(41, 45);
            X.TabIndex = 12;
            X.Text = "X";
            X.Click += X_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.developers_high_resolution22_logo1;
            pictureBox1.Location = new Point(25, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btn_LogOut
            // 
            btn_LogOut.BackColor = Color.White;
            btn_LogOut.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn_LogOut.FlatAppearance.BorderSize = 3;
            btn_LogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_LogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_LogOut.ForeColor = SystemColors.Highlight;
            btn_LogOut.Location = new Point(881, 9);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new Size(129, 45);
            btn_LogOut.TabIndex = 13;
            btn_LogOut.Text = "back";
            btn_LogOut.UseVisualStyleBackColor = false;
            btn_LogOut.Click += btn_LogOut_Click;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(164, 184);
            txt_Phone.Multiline = true;
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(225, 41);
            txt_Phone.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(40, 187);
            label7.Name = "label7";
            label7.Size = new Size(96, 38);
            label7.TabIndex = 13;
            label7.Text = "Phone";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(164, 270);
            txt_Email.Multiline = true;
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(225, 41);
            txt_Email.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(48, 273);
            label8.Name = "label8";
            label8.Size = new Size(88, 38);
            label8.TabIndex = 15;
            label8.Text = "Email";
            // 
            // lblResultPhone
            // 
            lblResultPhone.AutoSize = true;
            lblResultPhone.Location = new Point(250, 228);
            lblResultPhone.Name = "lblResultPhone";
            lblResultPhone.Size = new Size(0, 25);
            lblResultPhone.TabIndex = 17;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(249, 316);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 18;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.programming_background5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 523);
            Controls.Add(btn_LogOut);
            Controls.Add(pictureBox1);
            Controls.Add(X);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            Load += EditProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Name;
        private TextBox txt_Password;
        private Label label2;
        private TextBox txt_Address;
        private Label label3;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button button1;
        private Panel panel1;
        private TextBox txt_OldPassword;
        private Label label4;
        private Button button2;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Label X;
        private PictureBox pictureBox1;
        private CheckBox login_showPass;
        private Button btn_LogOut;
        private Label lblResult;
        private Label lblResultPhone;
        private TextBox txt_Email;
        private Label label8;
        private TextBox txt_Phone;
        private Label label7;
    }
}