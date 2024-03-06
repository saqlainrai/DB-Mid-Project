using CrystalDecisions.CrystalReports.Engine;
using Main_Project.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAddStudent.Visible = false;
            btnUpdateStudent.Visible = false;
            btnDeleteStudent.Visible = false;
            btnAddCLO.Visible = false;
            btnUpdateCLO.Visible = false;
            btnDeleteCLO.Visible = false;
            btnAddAssessment.Visible = false;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (btnAddStudent.Visible)
            {
                btnAddStudent.Visible = false;
                btnUpdateStudent.Visible = false;
                btnDeleteStudent.Visible = false;
            }
            else
            {
                btnUpdateStudent.Visible = true;
                btnAddStudent.Visible = true;
                btnDeleteStudent.Visible = true;
            }
        }

        private void btnCLO_Click(object sender, EventArgs e)
        {
            if (btnAddCLO.Visible)
            {
                btnAddCLO.Visible = false;
                btnUpdateCLO.Visible = false;
                btnDeleteCLO.Visible = false;
            }
            else
            {
                btnAddCLO.Visible = true;
                btnUpdateCLO.Visible = true;
                btnDeleteCLO.Visible = true;
            }
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            if (btnAddAssessment.Visible)
            {
                btnAddAssessment.Visible = false;
            }
            else
            {
                btnAddAssessment.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do you want to Exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            DisplayForm(new AddStudent());
        }
        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            DisplayForm(new UpdateStudent());
        }
        public void DisplayForm(UserControl form)
        {
            /// Setting up the properties of docking the form into our parent application

            if (panel_data.Controls.Count > 0)
            {
                // Our panel already contained a form, we need to clear it and set it again.
                panel_data.Controls.Clear();
            }
            //form.TopLevel = false;
            //form.FormBorderStyle = FormBorderStyle.None;
            form.Parent = this.panel_data;
            form.Location = new Point(panel_data.Location.X, panel_data.Location.Y);
            //form.Location = new Point(200, 50);
            form.Size = panel_data.Size;
            form.Dock = DockStyle.Fill;
            panel_data.Controls.Add(form);

            /// Showing the form
            form.Show();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ShowReport();
        }
        private void ShowReport()
        {
            //ReportDocument r = new ReportDocument();
            //string path = Application.StartupPath;
            //string reportpath = @"CrystalReport1.rpt";
            //string fpath = Path.Combine(path, reportpath);
            //r.Load(fpath);
            //crystalReportViewer1.ReportSource = r;
        }

    }
}
