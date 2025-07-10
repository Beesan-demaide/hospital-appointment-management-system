namespace HospitalMangmentFrontend.Forms
{
    partial class Add_New_Doctor
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
            txtName = new TextBox();
            txtPassword = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            button2 = new Button();
            txtSpecialty = new TextBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.Blue;
            txtName.Location = new Point(170, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 22);
            txtName.TabIndex = 34;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Blue;
            txtPassword.Location = new Point(170, 117);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(194, 22);
            txtPassword.TabIndex = 32;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MediumBlue;
            label7.Location = new Point(90, 117);
            label7.Name = "label7";
            label7.Size = new Size(74, 16);
            label7.TabIndex = 31;
            label7.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(90, 160);
            label4.Name = "label4";
            label4.Size = new Size(75, 16);
            label4.TabIndex = 29;
            label4.Text = "Specialty:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(112, 77);
            label3.Name = "label3";
            label3.Size = new Size(50, 16);
            label3.TabIndex = 28;
            label3.Text = "Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(65, 277);
            panel1.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Khaki;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(61, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(417, 49);
            panel3.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(169, 35);
            label2.TabIndex = 0;
            label2.Text = "Add New Doctor";
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Azure;
            button2.Location = new Point(224, 206);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(61, 31);
            button2.TabIndex = 39;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtSpecialty
            // 
            txtSpecialty.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSpecialty.ForeColor = Color.Blue;
            txtSpecialty.Location = new Point(170, 154);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(194, 22);
            txtSpecialty.TabIndex = 40;
            // 
            // Add_New_Doctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 274);
            Controls.Add(txtSpecialty);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(txtName);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Add_New_Doctor";
            Text = "Add_New_Doctor";
            Load += Add_New_Doctor_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private TextBox txtPassword;
        private Label label7;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Button button2;
        private TextBox txtSpecialty;
    }
}