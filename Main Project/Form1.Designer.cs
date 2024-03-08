namespace Main_Project
{
    partial class Form1
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnRubrics = new System.Windows.Forms.Button();
            this.btnAddAssessment = new System.Windows.Forms.Button();
            this.btnAssessment = new System.Windows.Forms.Button();
            this.btnDeleteCLO = new System.Windows.Forms.Button();
            this.btnUpdateCLO = new System.Windows.Forms.Button();
            this.btnAddCLO = new System.Windows.Forms.Button();
            this.btnCLO = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel_data = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(101)))), ((int)(((byte)(144)))));
            this.panel_top.Controls.Add(this.panel1);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Location = new System.Drawing.Point(262, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1032, 66);
            this.panel_top.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(980, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 38);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Dashboard!!!";
            // 
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.Controls.Add(this.btnExit);
            this.panelSide.Controls.Add(this.btnReports);
            this.panelSide.Controls.Add(this.btnRubrics);
            this.panelSide.Controls.Add(this.btnAddAssessment);
            this.panelSide.Controls.Add(this.btnAssessment);
            this.panelSide.Controls.Add(this.btnDeleteCLO);
            this.panelSide.Controls.Add(this.btnUpdateCLO);
            this.panelSide.Controls.Add(this.btnAddCLO);
            this.panelSide.Controls.Add(this.btnCLO);
            this.panelSide.Controls.Add(this.btnDeleteStudent);
            this.panelSide.Controls.Add(this.btnUpdateStudent);
            this.panelSide.Controls.Add(this.btnAddStudent);
            this.panelSide.Controls.Add(this.btnStudent);
            this.panelSide.Location = new System.Drawing.Point(0, 64);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(263, 622);
            this.panelSide.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(0, 600);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(242, 50);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReports
            // 
            this.btnReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Location = new System.Drawing.Point(0, 550);
            this.btnReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(242, 50);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnRubrics
            // 
            this.btnRubrics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRubrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRubrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRubrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRubrics.Location = new System.Drawing.Point(0, 500);
            this.btnRubrics.Margin = new System.Windows.Forms.Padding(0);
            this.btnRubrics.Name = "btnRubrics";
            this.btnRubrics.Size = new System.Drawing.Size(242, 50);
            this.btnRubrics.TabIndex = 7;
            this.btnRubrics.Text = "Rubrics";
            this.btnRubrics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRubrics.UseVisualStyleBackColor = false;
            this.btnRubrics.Click += new System.EventHandler(this.btnRubrics_Click);
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddAssessment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAssessment.Location = new System.Drawing.Point(0, 450);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(242, 50);
            this.btnAddAssessment.TabIndex = 13;
            this.btnAddAssessment.Text = "Add Assessment";
            this.btnAddAssessment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAssessment.UseVisualStyleBackColor = false;
            this.btnAddAssessment.Click += new System.EventHandler(this.btnAddAssessment_Click);
            // 
            // btnAssessment
            // 
            this.btnAssessment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAssessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAssessment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessment.Location = new System.Drawing.Point(0, 400);
            this.btnAssessment.Margin = new System.Windows.Forms.Padding(0);
            this.btnAssessment.Name = "btnAssessment";
            this.btnAssessment.Size = new System.Drawing.Size(242, 50);
            this.btnAssessment.TabIndex = 6;
            this.btnAssessment.Text = "Assessment";
            this.btnAssessment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssessment.UseVisualStyleBackColor = false;
            this.btnAssessment.Click += new System.EventHandler(this.btnAssessment_Click);
            // 
            // btnDeleteCLO
            // 
            this.btnDeleteCLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteCLO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteCLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCLO.Location = new System.Drawing.Point(0, 350);
            this.btnDeleteCLO.Name = "btnDeleteCLO";
            this.btnDeleteCLO.Size = new System.Drawing.Size(242, 50);
            this.btnDeleteCLO.TabIndex = 11;
            this.btnDeleteCLO.Text = "Delete CLO";
            this.btnDeleteCLO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCLO.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCLO
            // 
            this.btnUpdateCLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdateCLO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateCLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCLO.Location = new System.Drawing.Point(0, 300);
            this.btnUpdateCLO.Name = "btnUpdateCLO";
            this.btnUpdateCLO.Size = new System.Drawing.Size(242, 50);
            this.btnUpdateCLO.TabIndex = 12;
            this.btnUpdateCLO.Text = "Update CLO";
            this.btnUpdateCLO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCLO.UseVisualStyleBackColor = false;
            // 
            // btnAddCLO
            // 
            this.btnAddCLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddCLO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCLO.Location = new System.Drawing.Point(0, 250);
            this.btnAddCLO.Name = "btnAddCLO";
            this.btnAddCLO.Size = new System.Drawing.Size(242, 50);
            this.btnAddCLO.TabIndex = 10;
            this.btnAddCLO.Text = "Add CLO";
            this.btnAddCLO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCLO.UseVisualStyleBackColor = false;
            // 
            // btnCLO
            // 
            this.btnCLO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCLO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLO.Location = new System.Drawing.Point(0, 200);
            this.btnCLO.Margin = new System.Windows.Forms.Padding(0);
            this.btnCLO.Name = "btnCLO";
            this.btnCLO.Size = new System.Drawing.Size(242, 50);
            this.btnCLO.TabIndex = 5;
            this.btnCLO.Text = "CLO";
            this.btnCLO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCLO.UseVisualStyleBackColor = false;
            this.btnCLO.Click += new System.EventHandler(this.btnCLO_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Location = new System.Drawing.Point(0, 150);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(242, 50);
            this.btnDeleteStudent.TabIndex = 3;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdateStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Location = new System.Drawing.Point(0, 100);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(242, 50);
            this.btnUpdateStudent.TabIndex = 4;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 50);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(242, 50);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Location = new System.Drawing.Point(0, 0);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(242, 50);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panel_data
            // 
            this.panel_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel_data.Location = new System.Drawing.Point(262, 64);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(1032, 570);
            this.panel_data.TabIndex = 5;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(0, -1);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(263, 66);
            this.btnMain.TabIndex = 5;
            this.btnMain.Text = "Score Master";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 626);
            this.Controls.Add(this.panel_data);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_top.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnRubrics;
        private System.Windows.Forms.Button btnAddAssessment;
        private System.Windows.Forms.Button btnAssessment;
        private System.Windows.Forms.Button btnDeleteCLO;
        private System.Windows.Forms.Button btnUpdateCLO;
        private System.Windows.Forms.Button btnAddCLO;
        private System.Windows.Forms.Button btnCLO;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel panel_data;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel panel1;
    }
}

