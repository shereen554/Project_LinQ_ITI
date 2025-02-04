namespace MyCompany
{
    partial class ShowProfile
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
            lb_Name = new Label();
            label1 = new Label();
            lb_Dept = new Label();
            lb_userName = new Label();
            cb_Project = new ComboBox();
            label2 = new Label();
            lb_supervisor = new Label();
            label4 = new Label();
            btn_Edit_profile = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lb_Name.ForeColor = SystemColors.Highlight;
            lb_Name.Location = new Point(124, 286);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(80, 32);
            lb_Name.TabIndex = 0;
            lb_Name.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(545, 106);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 1;
            label1.Text = "Your Department :";
            // 
            // lb_Dept
            // 
            lb_Dept.AutoSize = true;
            lb_Dept.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lb_Dept.ForeColor = SystemColors.Highlight;
            lb_Dept.Location = new Point(792, 106);
            lb_Dept.Name = "lb_Dept";
            lb_Dept.Size = new Size(66, 32);
            lb_Dept.TabIndex = 2;
            lb_Dept.Text = "Dept";
            // 
            // lb_userName
            // 
            lb_userName.AutoSize = true;
            lb_userName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lb_userName.ForeColor = SystemColors.Highlight;
            lb_userName.Location = new Point(98, 332);
            lb_userName.Name = "lb_userName";
            lb_userName.Size = new Size(135, 32);
            lb_userName.TabIndex = 3;
            lb_userName.Text = "User Name";
            // 
            // cb_Project
            // 
            cb_Project.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            cb_Project.ForeColor = SystemColors.Highlight;
            cb_Project.FormattingEnabled = true;
            cb_Project.Location = new Point(760, 258);
            cb_Project.Name = "cb_Project";
            cb_Project.Size = new Size(182, 40);
            cb_Project.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(596, 261);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 5;
            label2.Text = "Your Project";
            // 
            // lb_supervisor
            // 
            lb_supervisor.AutoSize = true;
            lb_supervisor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lb_supervisor.ForeColor = SystemColors.Highlight;
            lb_supervisor.Location = new Point(760, 167);
            lb_supervisor.Name = "lb_supervisor";
            lb_supervisor.Size = new Size(128, 32);
            lb_supervisor.TabIndex = 7;
            lb_supervisor.Text = "superVisor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(597, 167);
            label4.Name = "label4";
            label4.Size = new Size(143, 32);
            label4.TabIndex = 6;
            label4.Text = "SuperVisor :";
            // 
            // btn_Edit_profile
            // 
            btn_Edit_profile.BackColor = SystemColors.Highlight;
            btn_Edit_profile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_Edit_profile.ForeColor = Color.White;
            btn_Edit_profile.Location = new Point(385, 412);
            btn_Edit_profile.Name = "btn_Edit_profile";
            btn_Edit_profile.Size = new Size(292, 61);
            btn_Edit_profile.TabIndex = 8;
            btn_Edit_profile.Text = "Edit Profile";
            btn_Edit_profile.UseVisualStyleBackColor = false;
            btn_Edit_profile.Click += btn_Edit_profile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Person;
            pictureBox1.Location = new Point(87, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Andalus", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(353, 9);
            label3.Name = "label3";
            label3.Size = new Size(296, 79);
            label3.TabIndex = 10;
            label3.Text = "Your Profile";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(964, 9);
            label5.Name = "label5";
            label5.Size = new Size(41, 45);
            label5.TabIndex = 11;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // ShowProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1017, 522);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Edit_profile);
            Controls.Add(lb_supervisor);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cb_Project);
            Controls.Add(lb_userName);
            Controls.Add(lb_Dept);
            Controls.Add(label1);
            Controls.Add(lb_Name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowProfile";
            Load += ShowProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Name;
        private Label label1;
        private Label lb_Dept;
        private Label lb_userName;
        private ComboBox cb_Project;
        private Label label2;
        private Label lb_supervisor;
        private Label label4;
        private Button btn_Edit_profile;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label5;
    }
}