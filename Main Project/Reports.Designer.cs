namespace Main_Project
{
    partial class Reports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkInActive = new System.Windows.Forms.CheckBox();
            this.btnPrintStudents = new System.Windows.Forms.Button();
            this.btnPrintAttendance = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSpecificStudent = new System.Windows.Forms.Button();
            this.btnPercentageAttendance = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Print the List of Students...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Print the Attendance of Students for this Date...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(342, 99);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(148, 24);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Active Students";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // chkInActive
            // 
            this.chkInActive.AutoSize = true;
            this.chkInActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInActive.Location = new System.Drawing.Point(497, 99);
            this.chkInActive.Name = "chkInActive";
            this.chkInActive.Size = new System.Drawing.Size(167, 24);
            this.chkInActive.TabIndex = 3;
            this.chkInActive.Text = "In-Active Students";
            this.chkInActive.UseVisualStyleBackColor = true;
            // 
            // btnPrintStudents
            // 
            this.btnPrintStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintStudents.Location = new System.Drawing.Point(702, 83);
            this.btnPrintStudents.Name = "btnPrintStudents";
            this.btnPrintStudents.Size = new System.Drawing.Size(130, 40);
            this.btnPrintStudents.TabIndex = 4;
            this.btnPrintStudents.Text = "Print";
            this.btnPrintStudents.UseVisualStyleBackColor = true;
            this.btnPrintStudents.Click += new System.EventHandler(this.btnPrintStudents_Click);
            // 
            // btnPrintAttendance
            // 
            this.btnPrintAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAttendance.Location = new System.Drawing.Point(702, 185);
            this.btnPrintAttendance.Name = "btnPrintAttendance";
            this.btnPrintAttendance.Size = new System.Drawing.Size(130, 41);
            this.btnPrintAttendance.TabIndex = 5;
            this.btnPrintAttendance.Text = "Print";
            this.btnPrintAttendance.UseVisualStyleBackColor = true;
            this.btnPrintAttendance.Click += new System.EventHandler(this.btnPrintAttendance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Generate the Reports";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Print the Attendance of a Specific Student...";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(458, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // btnSpecificStudent
            // 
            this.btnSpecificStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecificStudent.Location = new System.Drawing.Point(702, 239);
            this.btnSpecificStudent.Name = "btnSpecificStudent";
            this.btnSpecificStudent.Size = new System.Drawing.Size(130, 41);
            this.btnSpecificStudent.TabIndex = 10;
            this.btnSpecificStudent.Text = "Print";
            this.btnSpecificStudent.UseVisualStyleBackColor = true;
            this.btnSpecificStudent.Click += new System.EventHandler(this.btnSpecificStudent_Click);
            // 
            // btnPercentageAttendance
            // 
            this.btnPercentageAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentageAttendance.Location = new System.Drawing.Point(702, 295);
            this.btnPercentageAttendance.Name = "btnPercentageAttendance";
            this.btnPercentageAttendance.Size = new System.Drawing.Size(130, 41);
            this.btnPercentageAttendance.TabIndex = 13;
            this.btnPercentageAttendance.Text = "Print";
            this.btnPercentageAttendance.UseVisualStyleBackColor = true;
            this.btnPercentageAttendance.Click += new System.EventHandler(this.btnPercentageAttendance_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(557, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Print the Percentage Attendance Report of all Active Students...";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnPercentageAttendance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSpecificStudent);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrintAttendance);
            this.Controls.Add(this.btnPrintStudents);
            this.Controls.Add(this.chkInActive);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(899, 471);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkInActive;
        private System.Windows.Forms.Button btnPrintStudents;
        private System.Windows.Forms.Button btnPrintAttendance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSpecificStudent;
        private System.Windows.Forms.Button btnPercentageAttendance;
        private System.Windows.Forms.Label label5;
    }
}
