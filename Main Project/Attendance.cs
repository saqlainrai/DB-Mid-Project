using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class Attendance : UserControl
    {
        public Attendance()
        {
            InitializeComponent();
            dateTimePicker1.Visible = false;
            btnOk.Visible = false;
            DateTime s = dateTimePicker1.Value;
            reloadData();
            //label1.Text = s.ToString();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnChooseDate_Click(object sender, EventArgs e)
        {
            btnPrintAttendance.Visible = false;
            btnSubmitAttendance.Visible = false;
            btnChooseDate.Visible = false;
            btnOk.Visible = true;
            dateTimePicker1.Visible = true;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            btnPrintAttendance.Visible = true;
            btnSubmitAttendance.Visible = true;
            btnChooseDate.Visible = true;
            btnOk.Visible = false;
            dateTimePicker1.Visible = false;
            DateTime s = dateTimePicker1.Value;
        }
        private void reloadData()
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT Id, CONCAT(FirstName, ' ', LastName) AS Name, RegistrationNumber FROM Student WHERE Status = 5";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnPrintAttendance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Working on this Feature!");
        }

        private void btnSubmitAttendance_Click(object sender, EventArgs e)
        {
            // Add Attendance to Database
            string selectedDate = dateTimePicker1.Value.ToString();
            var con = Configuration.getInstance().getConnection();
            string query = "INSERT INTO ClassAttendance VALUES(@date)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@date", selectedDate);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Class Attendance Added SUccessfully!");

            int classID = returnClassID(selectedDate);
            InsertStudentAttendance(classID);

            // Attendance has been successfully marked!!!
        }
        private int returnClassID(string selectedDate)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT Id FROM ClassAttendance WHERE AttendanceDate = @date";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@date", selectedDate);
            return (int)cmd.ExecuteScalar();
        }
        private void InsertStudentAttendance(int classID)
        {
            try
            {
                string registration = "";
                int sID = 0;
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    registration = row.Cells[3].Value.ToString();
                    sID = (int)row.Cells[1].Value;

                    if (row.Cells[0].Value == null) throw new Exception("Attendance not marked against a student");

                    else if (row.Cells[0].Value.ToString() == "PRESENT")
                    {
                        InsertIndividualStudent(sID, classID, 1);
                    }
                    else if (row.Cells[0].Value.ToString() == "ABSENT")
                    {
                        InsertIndividualStudent(sID, classID, 2);
                    }
                    else if (row.Cells[0].Value.ToString() == "LEAVE")
                    {
                        InsertIndividualStudent(sID, classID, 3);
                    }
                    else if (row.Cells[0].Value.ToString() == "LATE")
                    {
                        InsertIndividualStudent(sID, classID, 4);
                    }
                }
                MessageBox.Show("Attendance has been marked Successfully for the Selected Date.");
                this.dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InsertIndividualStudent(int studentID, int classID, int status)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "INSERT INTO StudentAttendance (AttendanceID,StudentID,AttendanceStatus) VALUES (@attID,@stuID,@stat)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@attID", classID);
            cmd.Parameters.AddWithValue("@stuID", studentID);
            cmd.Parameters.AddWithValue("@stat", status);
            cmd.ExecuteNonQuery();
        }
    }
}
