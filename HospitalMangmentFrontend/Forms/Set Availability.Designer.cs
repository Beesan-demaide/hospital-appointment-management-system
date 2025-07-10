namespace HospitalMangmentFrontend
{
    partial class Set_Availability
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
            label2 = new Label();
            label7 = new Label();
            label4 = new Label();
            Available = new CheckBox();
            EndTime = new DateTimePicker();
            StartTime = new DateTimePicker();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Available);
            panel1.Controls.Add(EndTime);
            panel1.Controls.Add(StartTime);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 307);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(38, 163);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 19;
            label2.Text = "Available:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(38, 115);
            label7.Name = "label7";
            label7.Size = new Size(77, 16);
            label7.TabIndex = 18;
            label7.Text = "End Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(38, 67);
            label4.Name = "label4";
            label4.Size = new Size(85, 16);
            label4.TabIndex = 13;
            label4.Text = "Start Time:";
            // 
            // Available
            // 
            Available.AutoSize = true;
            Available.Location = new Point(183, 163);
            Available.Name = "Available";
            Available.Size = new Size(74, 19);
            Available.TabIndex = 12;
            Available.Text = "Available";
            Available.UseVisualStyleBackColor = true;
            // 
            // EndTime
            // 
            EndTime.Format = DateTimePickerFormat.Custom;
            EndTime.Location = new Point(129, 110);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(200, 23);
            EndTime.TabIndex = 11;
            // 
            // StartTime
            // 
            StartTime.Format = DateTimePickerFormat.Custom;
            StartTime.Location = new Point(129, 67);
            StartTime.Name = "StartTime";
            StartTime.Size = new Size(200, 23);
            StartTime.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Azure;
            button1.Location = new Point(164, 225);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(87, 35);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 37);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(11, 7);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 0;
            label1.Text = "Set Availability";
            // 
            // Set_Availability
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 308);
            Controls.Add(panel1);
            Name = "Set_Availability";
            Text = "Set_Availability";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox Available;
        private DateTimePicker EndTime;
        private DateTimePicker StartTime;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label4;
    }
}