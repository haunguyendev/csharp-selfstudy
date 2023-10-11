namespace PRNslot3
{
    partial class Form1
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
            lbNumber1 = new Label();
            textNum1 = new TextBox();
            lbNumber2 = new Label();
            textNum2 = new TextBox();
            label1 = new Label();
            cbCong = new CheckBox();
            cbNhan = new CheckBox();
            cbTru = new CheckBox();
            cbChia = new CheckBox();
            btnTinh = new Button();
            label2 = new Label();
            lbResult = new Label();
            SuspendLayout();
            // 
            // lbNumber1
            // 
            lbNumber1.AutoSize = true;
            lbNumber1.Location = new Point(40, 61);
            lbNumber1.Margin = new Padding(5, 0, 5, 0);
            lbNumber1.Name = "lbNumber1";
            lbNumber1.Size = new Size(127, 32);
            lbNumber1.TabIndex = 0;
            lbNumber1.Text = "Number 1:";
            lbNumber1.Click += label1_Click;
            // 
            // textNum1
            // 
            textNum1.Location = new Point(186, 61);
            textNum1.Name = "textNum1";
            textNum1.Size = new Size(184, 39);
            textNum1.TabIndex = 1;
            // 
            // lbNumber2
            // 
            lbNumber2.AutoSize = true;
            lbNumber2.Location = new Point(40, 142);
            lbNumber2.Name = "lbNumber2";
            lbNumber2.Size = new Size(127, 32);
            lbNumber2.TabIndex = 2;
            lbNumber2.Text = "Number 2:";
            lbNumber2.Click += label2_Click;
            // 
            // textNum2
            // 
            textNum2.Location = new Point(186, 139);
            textNum2.Name = "textNum2";
            textNum2.Size = new Size(181, 39);
            textNum2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 220);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 4;
            label1.Text = "Operation:";
            // 
            // cbCong
            // 
            cbCong.AutoSize = true;
            cbCong.Location = new Point(187, 220);
            cbCong.Name = "cbCong";
            cbCong.Size = new Size(93, 36);
            cbCong.TabIndex = 5;
            cbCong.Text = "Cộng";
            cbCong.UseVisualStyleBackColor = true;
            cbCong.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cbNhan
            // 
            cbNhan.AutoSize = true;
            cbNhan.Location = new Point(186, 292);
            cbNhan.Name = "cbNhan";
            cbNhan.Size = new Size(94, 36);
            cbNhan.TabIndex = 6;
            cbNhan.Text = "Nhân";
            cbNhan.UseVisualStyleBackColor = true;
            // 
            // cbTru
            // 
            cbTru.AutoSize = true;
            cbTru.Location = new Point(298, 220);
            cbTru.Name = "cbTru";
            cbTru.Size = new Size(69, 36);
            cbTru.TabIndex = 7;
            cbTru.Text = "Trừ";
            cbTru.UseVisualStyleBackColor = true;
            // 
            // cbChia
            // 
            cbChia.AutoSize = true;
            cbChia.Location = new Point(298, 292);
            cbChia.Name = "cbChia";
            cbChia.Size = new Size(83, 36);
            cbChia.TabIndex = 8;
            cbChia.Text = "Chia";
            cbChia.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            btnTinh.BackColor = SystemColors.ControlLight;
            btnTinh.Location = new Point(186, 346);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(129, 44);
            btnTinh.TabIndex = 9;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.Click += btnTinh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(425, 146);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(78, 32);
            lbResult.TabIndex = 11;
            lbResult.Text = "Result";
            lbResult.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 485);
            Controls.Add(lbResult);
            Controls.Add(label2);
            Controls.Add(btnTinh);
            Controls.Add(cbChia);
            Controls.Add(cbTru);
            Controls.Add(cbNhan);
            Controls.Add(cbCong);
            Controls.Add(label1);
            Controls.Add(textNum2);
            Controls.Add(lbNumber2);
            Controls.Add(textNum1);
            Controls.Add(lbNumber1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(5);
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumber1;
        private TextBox textNum1;
        private Label lbNumber2;
        private TextBox textNum2;
        private Label label1;
        private CheckBox cbCong;
        private CheckBox cbNhan;
        private CheckBox cbTru;
        private CheckBox cbChia;
        private Button btnTinh;
        private Label label2;
        private Label lbResult;
    }
}