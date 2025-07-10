namespace HospitalMangmentFrontend.Forms
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            textBoxPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            txtUserName = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(63, 26);
            label1.TabIndex = 0;
            label1.Text = "Log in";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-1, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 185);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.logoo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxPassword);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(txtUserName);
            panel3.Location = new Point(171, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 185);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(103, 79);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(194, 23);
            textBoxPassword.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(23, 81);
            label4.Name = "label4";
            label4.Size = new Size(74, 16);
            label4.TabIndex = 11;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(16, 39);
            label3.Name = "label3";
            label3.Size = new Size(81, 16);
            label3.TabIndex = 10;
            label3.Text = "UserName:";
            label3.Click += label3_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Navy;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Azure;
            btnLogin.Location = new Point(156, 123);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.Yes;
            btnLogin.Size = new Size(87, 34);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.Blue;
            txtUserName.Location = new Point(103, 39);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(194, 22);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += textBox1_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 227);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private TextBox txtUserName;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private CheckBox Passcheckbox;
        private TextBox textBoxPassword;
    }
}