namespace HospitalMangmentFrontend.Forms
{
    partial class SearchDoctors
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
            panel2 = new Panel();
            DoctorsGrid = new DataGridView();
            Available = new CheckBox();
            label3 = new Label();
            btnSave = new Button();
            txtSpecialty = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorsGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(DoctorsGrid);
            panel2.Controls.Add(Available);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtSpecialty);
            panel2.Location = new Point(-2, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(553, 293);
            panel2.TabIndex = 2;
            // 
            // DoctorsGrid
            // 
            DoctorsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DoctorsGrid.GridColor = Color.White;
            DoctorsGrid.Location = new Point(3, 106);
            DoctorsGrid.Name = "DoctorsGrid";
            DoctorsGrid.Size = new Size(550, 184);
            DoctorsGrid.TabIndex = 13;
            // 
            // Available
            // 
            Available.AutoSize = true;
            Available.Location = new Point(245, 25);
            Available.Name = "Available";
            Available.Size = new Size(74, 19);
            Available.TabIndex = 12;
            Available.Text = "Available";
            Available.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(22, 25);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 11;
            label3.Text = "Specialty:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Khaki;
            btnSave.Font = new Font("Sitka Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Navy;
            btnSave.Location = new Point(160, 61);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.Yes;
            btnSave.Size = new Size(55, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Search";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSpecialty
            // 
            txtSpecialty.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSpecialty.ForeColor = Color.Blue;
            txtSpecialty.Location = new Point(103, 24);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(127, 22);
            txtSpecialty.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 53);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(133, 19);
            label1.TabIndex = 1;
            label1.Text = "Searching Doctors";
            // 
            // SearchDoctors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 338);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "SearchDoctors";
            Text = "Form1";
            Load += SearchDoctors_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorsGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private Button btnSave;
        private TextBox txtSpecialty;
        private Panel panel1;
        private Label label1;
        private DataGridView DoctorsGrid;
        private CheckBox Available;
    }
}