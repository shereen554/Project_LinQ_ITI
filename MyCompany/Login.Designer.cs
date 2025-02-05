namespace MyCompany
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            login_showPass = new CheckBox();
            linkLabel1 = new LinkLabel();
            btn_login = new Button();
            label4 = new Label();
            txt_passowrd = new TextBox();
            label3 = new Label();
            txt_userName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 62);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(1090, 9);
            label2.Name = "label2";
            label2.Size = new Size(37, 38);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.developers_high_resolution22_logo;
            pictureBox1.Location = new Point(0, -30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(login_showPass);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(btn_login);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_passowrd);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_userName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(567, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 479);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.ForeColor = SystemColors.HotTrack;
            login_showPass.Location = new Point(214, 282);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(82, 29);
            login_showPass.TabIndex = 7;
            login_showPass.Text = "Show";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(214, 338);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(244, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Do you not have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.MenuHighlight;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(208, 387);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(144, 47);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(18, 221);
            label4.Name = "label4";
            label4.Size = new Size(171, 45);
            label4.TabIndex = 4;
            label4.Text = "passowrd";
            // 
            // txt_passowrd
            // 
            txt_passowrd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_passowrd.Location = new Point(205, 220);
            txt_passowrd.Multiline = true;
            txt_passowrd.Name = "txt_passowrd";
            txt_passowrd.PasswordChar = '*';
            txt_passowrd.Size = new Size(308, 46);
            txt_passowrd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(18, 134);
            label3.Name = "label3";
            label3.Size = new Size(192, 45);
            label3.TabIndex = 2;
            label3.Text = "User Name";
            // 
            // txt_userName
            // 
            txt_userName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_userName.Location = new Point(205, 133);
            txt_userName.Multiline = true;
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(308, 46);
            txt_userName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(205, 15);
            label1.Name = "label1";
            label1.Size = new Size(153, 45);
            label1.TabIndex = 0;
            label1.Text = "Login\U0001fa75";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.programming_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1139, 667);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox txt_userName;
        private Label label4;
        private TextBox txt_passowrd;
        private Label label3;
        private Button btn_login;
        private LinkLabel linkLabel1;
        private CheckBox login_showPass;
    }
}
