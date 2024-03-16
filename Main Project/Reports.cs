using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
            fillCombo();
        }
        private void fillCombo()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT RegistrationNumber FROM Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            List<string> columnEntries = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                columnEntries.Add(row["RegistrationNumber"].ToString());
            }
            foreach (string column in columnEntries)
            {
                comboBox1.Items.Add(column);
            }
            comboBox1.SelectedIndex = 0;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintStudents_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Student";
            string tableHeader = "All Students Details";
            if (chkActive.Checked || chkInActive.Checked)
            {
                // Take the file Name from the User
                string fileName = PdfGenerator.ShowInputDialog("Enter a valid file name(Add .pdf at end)(-1 to terminate): ");
                if (fileName == "-1")
                {
                    return;
                }
                if (string.IsNullOrEmpty(fileName) || !fileName.EndsWith(".pdf"))
                {
                    while (string.IsNullOrEmpty(fileName) || !fileName.EndsWith(".pdf"))
                    {
                        MessageBox.Show("Enter a Valid File Name!!!");
                        fileName = PdfGenerator.ShowInputDialog("Enter a valid file name(Add .pdf at end)(-1 to terminate): ");
                        if (fileName == "-1")
                        {
                            return;
                        }
                    }
                }

                if (chkActive.Checked && !chkInActive.Checked)
                {
                    query = "SELECT Id, CONCAT(FirstName, ' ', LastName) AS Name, Contact, Email, RegistrationNumber FROM Student WHERE Status = 5";
                    tableHeader = "Active Students Details";
                }
                else if (!chkActive.Checked && chkInActive.Checked)
                {
                    query = "SELECT Id, CONCAT(FirstName, ' ', LastName) AS Name, Contact, Email, RegistrationNumber FROM Student WHERE Status = 6";
                    tableHeader = "In-Active Students Details";
                }
                var connection = Configuration.getInstance().getConnection();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                
                PdfGenerator.PrintDataToDocument(dataTable, fileName, tableHeader);
            }
            else
            {
                MessageBox.Show("Please Mark the Valid Checkboxes!!!");
            }
        }

        private void btnPrintAttendance_Click(object sender, EventArgs e)
        {
            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (Attendance.validateDateInAttendance(selectedDate))
            {
                var con = Configuration.getInstance().getConnection();
                string query = "SELECT t1.Id AttendanceID, t1.AttendanceDate, t2.StudentId, CONCAT(s.FirstName, ' ', s.LastName) Name, l.Name Status, s.RegistrationNumber FROM (SELECT * FROM ClassAttendance WHERE CONVERT(DATE, AttendanceDate) = @date) t1 JOIN StudentAttendance t2 ON t1.Id = t2.AttendanceId JOIN Lookup l ON l.LookupId = t2.AttendanceStatus JOIN Student s ON s.Id = t2.StudentId;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@date", selectedDate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                PdfGenerator.PrintDataToDocument(dataTable, "report.pdf", $"Attendance of {selectedDate}");
            }
            else
            {
                MessageBox.Show("The Attendance is not Marked for the corresponding date.");
            }
        }
        private void btnSpecificStudent_Click(object sender, EventArgs e)
        {
            string value = comboBox1.SelectedItem.ToString();
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT s.Id, CONCAT(s.FirstName, ' ', s.LastName) Name, s.RegistrationNumber, CONVERT(DATE, c.AttendanceDate) Date, l.Name Status FROM Student s JOIN StudentAttendance a ON s.Id = a.StudentId JOIN Lookup l ON l.LookupId = a.AttendanceStatus JOIN ClassAttendance c ON c.Id = a.AttendanceId WHERE s.RegistrationNumber = @rno";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@rno", value);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                PdfGenerator.PrintDataToDocument(dataTable, "report.pdf", $"Attendance of {value}");
            }
            else
            {
                MessageBox.Show("No Attendance is marked for this Student!!!");
            }
        }
    }
}
