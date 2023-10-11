namespace PRNslot3
{
    partial class Login
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
            textFullName = new TextBox();
            lbFullName = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // textFullName
            // 
            textFullName.Location = new Point(149, 147);
            textFullName.Name = "textFullName";
            textFullName.Size = new Size(206, 27);
            textFullName.TabIndex = 0;
            textFullName.TextChanged += textBox1_TextChanged;
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbFullName.Location = new Point(183, 102);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(116, 32);
            lbFullName.TabIndex = 1;
            lbFullName.Text = "FullName";
            lbFullName.Click += label1_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ControlLight;
            btnSubmit.Location = new Point(183, 195);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(141, 54);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(lbFullName);
            Controls.Add(textFullName);
            Name = "Login";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFullName;
        private Label lbFullName;
        private Button btnSubmit;
    }
}