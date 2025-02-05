namespace MyCompany
{
    partial class CRUD_Project
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
            dgv_Project = new DataGridView();
            txt_PName = new TextBox();
            label1 = new Label();
            cb_Dept = new ComboBox();
            label2 = new Label();
            txt_PLocation = new TextBox();
            label3 = new Label();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            label4 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Project).BeginInit();
            SuspendLayout();
            // 
            // dgv_Project
            // 
            dgv_Project.BackgroundColor = SystemColors.ButtonFace;
            dgv_Project.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Project.Dock = DockStyle.Bottom;
            dgv_Project.Location = new Point(0, 278);
            dgv_Project.Name = "dgv_Project";
            dgv_Project.RowHeadersWidth = 62;
            dgv_Project.Size = new Size(1036, 279);
            dgv_Project.TabIndex = 0;
            dgv_Project.CellContentClick += dataGridView1_CellContentClick;
            dgv_Project.RowHeaderMouseDoubleClick += dgv_Project_RowHeaderMouseDoubleClick;
            // 
            // txt_PName
            // 
            txt_PName.Location = new Point(222, 52);
            txt_PName.Multiline = true;
            txt_PName.Name = "txt_PName";
            txt_PName.Size = new Size(183, 31);
            txt_PName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(33, 49);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 2;
            label1.Text = "Project Name";
            // 
            // cb_Dept
            // 
            cb_Dept.FormattingEnabled = true;
            cb_Dept.Location = new Point(676, 50);
            cb_Dept.Name = "cb_Dept";
            cb_Dept.Size = new Size(201, 33);
            cb_Dept.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(70, 126);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 5;
            label2.Text = "Location";
            // 
            // txt_PLocation
            // 
            txt_PLocation.Location = new Point(222, 126);
            txt_PLocation.Multiline = true;
            txt_PLocation.Name = "txt_PLocation";
            txt_PLocation.Size = new Size(183, 31);
            txt_PLocation.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(518, 52);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 6;
            label3.Text = "Department";
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_add.ForeColor = SystemColors.Highlight;
            btn_add.Location = new Point(527, 154);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(117, 39);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.Highlight;
            btn_delete.Location = new Point(849, 154);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(117, 39);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_update.ForeColor = SystemColors.Highlight;
            btn_update.Location = new Point(676, 154);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(117, 39);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(989, 9);
            label4.Name = "label4";
            label4.Size = new Size(35, 38);
            label4.TabIndex = 10;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(12, 0);
            label10.Name = "label10";
            label10.Size = new Size(120, 38);
            label10.TabIndex = 26;
            label10.Text = "<--back";
            label10.Click += label10_Click;
            // 
            // CRUD_Project
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1036, 557);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_PLocation);
            Controls.Add(cb_Dept);
            Controls.Add(label1);
            Controls.Add(txt_PName);
            Controls.Add(dgv_Project);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CRUD_Project";
            Text = "CRUD_Project";
            Load += CRUD_Project_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Project).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Project;
        private TextBox txt_PName;
        private Label label1;
        private ComboBox cb_Dept;
        private Label label2;
        private TextBox txt_PLocation;
        private Label label3;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private Label label4;
        private Label label10;
    }
}