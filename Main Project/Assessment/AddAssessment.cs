using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project.Assessment
{
    public partial class AddAssessment : UserControl
    {
        public AddAssessment()
        {
            InitializeComponent();
            reloadData1();
            reloadData2();
            AddDatainComboBoxes();
        }
        private void AddDatainComboBoxes()
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT CONCAT(R.Id,'-',R.Details) FROM Rubric R";
            SqlCommand cmd = new SqlCommand(query, con);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboRubric.Items.Add(reader.GetString(0));
                }
            }

            query = "SELECT CONCAT(Id,'-',Title) FROM Assessment";
            cmd = new SqlCommand(query, con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboAssessment.Items.Add(reader.GetString(0));
                }
            }
            this.comboAssessment.SelectedIndex = 0;
            this.comboRubric.SelectedIndex = 0;
        }
        private void reloadData1()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Assessment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void reloadData2()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from AssessmentComponent", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btnAddAssessment_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            if (!(title == "" || title == null))
            {
                int marks = (int)intTotalMarks.Value;
                int weightage = (int)intTotalWeigh.Value;
                var con = Configuration.getInstance().getConnection();
                string query = "INSERT INTO Assessment (Title,DateCreated,TotalMarks,TotalWeightage) VALUES (@title,GETDATE(),@marks,@weightage)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@marks", marks);
                cmd.Parameters.AddWithValue("@weightage", weightage);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Assessment is Added Successfully!!!");
                reloadData1();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Title!!!");
            }
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (!(name == "" || name == null))
            {
                int marks = (int)intTotalMarks2.Value;
                //string rubric = comboRubric.Text;
                //string[] data = rubric.Split('-');
                //int rubricID = int.Parse(data[0]);
                int rubricID = int.Parse(comboRubric.Text.Split('-')[0]); //a shorter version
                int assessmentID = int.Parse(comboAssessment.Text.Split('-')[0]);
                int componentsTotal = GetAssessmentComponentMarksTotal(assessmentID) + marks;
                int assessmentTotal = GetAssessmentMarksTotal(assessmentID);
                if (componentsTotal <= assessmentTotal)
                {
                    var con = Configuration.getInstance().getConnection();
                    string query = "INSERT INTO AssessmentComponent (Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) VALUES (@name,@rubricId,@totalMarks,GETDATE(),GETDATE(),@assessmentId)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@rubricId", rubricID);
                    cmd.Parameters.AddWithValue("@totalMarks", marks);
                    cmd.Parameters.AddWithValue("@assessmentId", assessmentID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Assessment Component is Added Successfully!!!");
                    reloadData2();
                }
                else
                {
                    MessageBox.Show("The Total Marks of Components can not be greater than Assessment Marks");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Name!!!");
            }
        }
        private int GetAssessmentComponentMarksTotal(int assId)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT SUM(TotalMarks) FROM AssessmentComponent WHERE AssessmentId=@assId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("assId", assId);
            if (cmd.ExecuteScalar() == null || cmd.ExecuteScalar().ToString() == "") return 0;
            return (int)cmd.ExecuteScalar();
        }

        private int GetAssessmentMarksTotal(int assId)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT TotalMarks FROM Assessment WHERE Id=@assId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("assId", assId);
            //MessageBox.Show(cmd.ExecuteScalar().ToString());
            return (int)cmd.ExecuteScalar();
        }
    }
}
