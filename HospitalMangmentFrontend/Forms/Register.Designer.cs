namespace HospitalMangmentFrontend.Forms
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
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            button3 = new Button();
            cmbRoles = new ComboBox();
            checkBox = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(50, 66);
            label3.Name = "label3";
            label3.Size = new Size(50, 16);
            label3.TabIndex = 11;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(50, 188);
            label4.Name = "label4";
            label4.Size = new Size(42, 16);
            label4.TabIndex = 14;
            label4.Text = "Role:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(50, 102);
            label6.Name = "label6";
            label6.Size = new Size(52, 16);
            label6.TabIndex = 16;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MediumBlue;
            label7.Location = new Point(28, 144);
            label7.Name = "label7";
            label7.Size = new Size(74, 16);
            label7.TabIndex = 17;
            label7.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Blue;
            txtPassword.Location = new Point(108, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(194, 22);
            txtPassword.TabIndex = 18;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Blue;
            txtEmail.Location = new Point(108, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 22);
            txtEmail.TabIndex = 22;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.Blue;
            txtUserName.Location = new Point(108, 66);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(194, 22);
            txtUserName.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 49);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 26);
            label1.TabIndex = 1;
            label1.Text = "Register ";
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Azure;
            button3.Location = new Point(158, 240);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(87, 34);
            button3.TabIndex = 25;
            button3.Text = "Register ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Items.AddRange(new object[] { "", "Option 2" });
            cmbRoles.Location = new Point(108, 186);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(194, 23);
            cmbRoles.TabIndex = 26;
            cmbRoles.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox.Location = new Point(307, 145);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(108, 17);
            checkBox.TabIndex = 27;
            checkBox.Text = "ShowPassword ";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 273);
            Controls.Add(checkBox);
            Controls.Add(cmbRoles);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(txtUserName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Register";
            Text = "Register ";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox txtPassword;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private Panel panel1;
        private Label label1;
        private Button button3;
        private ComboBox cmbRoles;
        private Button button1;
        private CheckBox checkBox;
    }
}