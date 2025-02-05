namespace MyCompany
{
    partial class CRUD_Department
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
            dgv_Dept = new DataGridView();
            txt_DeptName = new TextBox();
            cb_Manager = new ComboBox();
            dt_MangeStar = new DateTimePicker();
            DepartMent = new Label();
            btn_add = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_update = new Button();
            btn_delete = new Button();
            label3 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Dept).BeginInit();
            SuspendLayout();
            // 
            // dgv_Dept
            // 
            dgv_Dept.BackgroundColor = SystemColors.ControlLightLight;
            dgv_Dept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Dept.Dock = DockStyle.Left;
            dgv_Dept.Location = new Point(0, 0);
            dgv_Dept.Name = "dgv_Dept";
            dgv_Dept.RowHeadersWidth = 62;
            dgv_Dept.Size = new Size(505, 551);
            dgv_Dept.TabIndex = 0;
            dgv_Dept.RowHeaderMouseDoubleClick += dgv_Dept_RowHeaderMouseDoubleClick;
            // 
            // txt_DeptName
            // 
            txt_DeptName.Location = new Point(832, 103);
            txt_DeptName.Name = "txt_DeptName";
            txt_DeptName.Size = new Size(178, 31);
            txt_DeptName.TabIndex = 1;
            // 
            // cb_Manager
            // 
            cb_Manager.FormattingEnabled = true;
            cb_Manager.Location = new Point(832, 254);
            cb_Manager.Name = "cb_Manager";
            cb_Manager.Size = new Size(182, 33);
            cb_Manager.TabIndex = 2;
            // 
            // dt_MangeStar
            // 
            dt_MangeStar.Location = new Point(832, 169);
            dt_MangeStar.Name = "dt_MangeStar";
            dt_MangeStar.Size = new Size(178, 31);
            dt_MangeStar.TabIndex = 3;
            // 
            // DepartMent
            // 
            DepartMent.AutoSize = true;
            DepartMent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DepartMent.ForeColor = SystemColors.Highlight;
            DepartMent.Location = new Point(662, 100);
            DepartMent.Name = "DepartMent";
            DepartMent.Size = new Size(135, 32);
            DepartMent.TabIndex = 4;
            DepartMent.Text = "Depatment";
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_add.ForeColor = SystemColors.Highlight;
            btn_add.Location = new Point(633, 379);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(114, 46);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(628, 168);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 6;
            label1.Text = "Manager Start";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(662, 254);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 7;
            label2.Text = "Manager";
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_update.ForeColor = SystemColors.Highlight;
            btn_update.Location = new Point(786, 379);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(114, 46);
            btn_update.TabIndex = 8;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.Highlight;
            btn_delete.Location = new Point(954, 379);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(114, 46);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(1094, 5);
            label3.Name = "label3";
            label3.Size = new Size(35, 38);
            label3.TabIndex = 10;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(511, 5);
            label10.Name = "label10";
            label10.Size = new Size(128, 38);
            label10.TabIndex = 26;
            label10.Text = "<-- back";
            label10.Click += label10_Click;
            // 
            // CRUD_Department
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1142, 551);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(DepartMent);
            Controls.Add(dt_MangeStar);
            Controls.Add(cb_Manager);
            Controls.Add(txt_DeptName);
            Controls.Add(dgv_Dept);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CRUD_Department";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD_Department";
            Load += CRUD_Department_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Dept).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Dept;
        private TextBox txt_DeptName;
        private ComboBox cb_Manager;
        private DateTimePicker dt_MangeStar;
        private Label DepartMent;
        private Button btn_add;
        private Label label1;
        private Label label2;
        private Button btn_update;
        private Button btn_delete;
        private Label label3;
        private Label label10;
    }
}