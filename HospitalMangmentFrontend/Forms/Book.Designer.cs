namespace HospitalMangmentFrontend.Forms
{
    partial class Book
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
            comboBoxTime = new ComboBox();
            button1 = new Button();
            SchedulesGrid = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            DatePicker = new DateTimePicker();
            BoxSpecialty = new ComboBox();
            bookbtn = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SchedulesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(comboBoxTime);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SchedulesGrid);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(DatePicker);
            panel1.Controls.Add(BoxSpecialty);
            panel1.Controls.Add(bookbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.Green;
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 399);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // comboBoxTime
            // 
            comboBoxTime.FormattingEnabled = true;
            comboBoxTime.Location = new Point(396, 108);
            comboBoxTime.Name = "comboBoxTime";
            comboBoxTime.Size = new Size(121, 23);
            comboBoxTime.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(534, 104);
            button1.Name = "button1";
            button1.Size = new Size(87, 34);
            button1.TabIndex = 17;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SchedulesGrid
            // 
            SchedulesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SchedulesGrid.Location = new Point(85, 163);
            SchedulesGrid.Name = "SchedulesGrid";
            SchedulesGrid.Size = new Size(422, 189);
            SchedulesGrid.TabIndex = 9;
            SchedulesGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(67, 108);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 16;
            label3.Text = "Select Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(57, 73);
            label4.Name = "label4";
            label4.Size = new Size(118, 16);
            label4.TabIndex = 15;
            label4.Text = "Select Specialty";
            label4.Click += label4_Click;
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(181, 108);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 8;
            // 
            // BoxSpecialty
            // 
            BoxSpecialty.FormattingEnabled = true;
            BoxSpecialty.Location = new Point(181, 73);
            BoxSpecialty.Name = "BoxSpecialty";
            BoxSpecialty.Size = new Size(121, 23);
            BoxSpecialty.TabIndex = 7;
            BoxSpecialty.SelectedIndexChanged += BoxSpecialty_SelectedIndexChanged;
            // 
            // bookbtn
            // 
            bookbtn.BackColor = Color.Navy;
            bookbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookbtn.ForeColor = Color.Azure;
            bookbtn.Location = new Point(257, 358);
            bookbtn.Name = "bookbtn";
            bookbtn.Size = new Size(87, 34);
            bookbtn.TabIndex = 3;
            bookbtn.Text = "Book";
            bookbtn.UseVisualStyleBackColor = false;
            bookbtn.Click += bookbtn_ClickAsync;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Hospital;
            pictureBox1.Location = new Point(13, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(0, 10);
            label2.Name = "label2";
            label2.Size = new Size(157, 19);
            label2.TabIndex = 2;
            label2.Text = " Management System";
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 398);
            Controls.Add(panel1);
            Name = "Book";
            Text = "Form1";
            Load += Form1_LoadAsync;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SchedulesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bookbtn;
        private PictureBox pictureBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ComboBox BoxSpecialty;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Button button1;
        private DateTimePicker DatePicker;
        private DataGridView SchedulesGrid;
        private ComboBox comboBoxTime;
    }
}