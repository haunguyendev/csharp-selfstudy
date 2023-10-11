namespace PRNslot3
{
    partial class ManageMentStudent
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
            lbStudentName = new Label();
            lbStudentPhone = new Label();
            txtStudentName = new TextBox();
            txtStudentPhone = new TextBox();
            dgvViewStudent = new DataGridView();
            btnSave = new Button();
            lbId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvViewStudent).BeginInit();
            SuspendLayout();
            // 
            // lbStudentName
            // 
            lbStudentName.AutoSize = true;
            lbStudentName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbStudentName.Location = new Point(24, 121);
            lbStudentName.Name = "lbStudentName";
            lbStudentName.Size = new Size(87, 32);
            lbStudentName.TabIndex = 0;
            lbStudentName.Text = "Họ tên";
            // 
            // lbStudentPhone
            // 
            lbStudentPhone.AutoSize = true;
            lbStudentPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbStudentPhone.Location = new Point(12, 172);
            lbStudentPhone.Name = "lbStudentPhone";
            lbStudentPhone.Size = new Size(132, 28);
            lbStudentPhone.TabIndex = 1;
            lbStudentPhone.Text = "Số điện thoại:";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(150, 126);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(248, 27);
            txtStudentName.TabIndex = 2;
            // 
            // txtStudentPhone
            // 
            txtStudentPhone.Location = new Point(150, 173);
            txtStudentPhone.Name = "txtStudentPhone";
            txtStudentPhone.Size = new Size(248, 27);
            txtStudentPhone.TabIndex = 3;
            // 
            // dgvViewStudent
            // 
            dgvViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewStudent.Location = new Point(443, 39);
            dgvViewStudent.Name = "dgvViewStudent";
            dgvViewStudent.RowHeadersWidth = 51;
            dgvViewStudent.RowTemplate.Height = 29;
            dgvViewStudent.Size = new Size(336, 283);
            dgvViewStudent.TabIndex = 4;
            dgvViewStudent.CellContentClick += dgvViewStudent_CellContentClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(198, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(38, 81);
            lbId.Name = "lbId";
            lbId.Size = new Size(22, 20);
            lbId.TabIndex = 6;
            lbId.Text = "Id";
            lbId.Click += label1_Click;
            // 
            // ManageMentStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbId);
            Controls.Add(btnSave);
            Controls.Add(dgvViewStudent);
            Controls.Add(txtStudentPhone);
            Controls.Add(txtStudentName);
            Controls.Add(lbStudentPhone);
            Controls.Add(lbStudentName);
            Name = "ManageMentStudent";
            Text = "ManageMentStudent";
            ((System.ComponentModel.ISupportInitialize)dgvViewStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStudentName;
        private Label lbStudentPhone;
        private TextBox txtStudentName;
        private TextBox txtStudentPhone;
        private DataGridView dgvViewStudent;
        private Button btnSave;
        private Label lbId;
    }
}