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

namespace Main_Project.Student
{
    public partial class UpdateStudent : UserControl
    {
        public UpdateStudent()
        {
            InitializeComponent();
            reloadData();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            //int rowIndex = -1;  
            //rowIndex = dataGridView1.SelectedRows[0].Index;
            //if (rowIndex >= 0)
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    string name = (string)txtName.Text;
                    string lastname = (string)txtLastName.Text;
                    string email = (string)txtEmail.Text;
                    string contact = (string)txtContact.Text;
                    string regno = (string)txtRegNo.Text;
                    bool s = radioActive.Checked;
                    int status = 6;
                    if (s)
                    {
                        status = 5;
                    }
                    if (name != "" && lastname != "")
                    {
                        if (email.EndsWith("@gmail.com") && email[0] != '@')
                        {
                            if (contact.Length == 10)
                            {
                                string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                                string oldReg = dataGridView1.CurrentRow.Cells["RegistrationNumber"].Value.ToString();
                                var c = Configuration.getInstance().getConnection();
                                SqlCommand cm = new SqlCommand("SELECT RegistrationNumber FROM Student", c);
                                SqlDataAdapter d = new SqlDataAdapter(cm);
                                DataTable dataTable = new DataTable();
                                d.Fill(dataTable);
                                List<string> columnEntries = new List<string>();
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    columnEntries.Add(row["RegistrationNumber"].ToString());
                                }
                                columnEntries.Remove(oldReg);
                                bool flag = false;
                                foreach (string column in columnEntries)
                                {
                                    if (column == regno)
                                    {
                                        flag = true;
                                    }
                                }
                                if (flag == false && regno != "")
                                {

                                    var con = Configuration.getInstance().getConnection();
                                    SqlCommand cmd = new SqlCommand("UPDATE Student SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, RegistrationNumber = @RegistrationNumber, Status = @Status WHERE ID = @ID", con);
                                    cmd.Parameters.AddWithValue("@FirstName", name);
                                    cmd.Parameters.AddWithValue("@LastName", lastname);
                                    cmd.Parameters.AddWithValue("@Contact", contact);
                                    cmd.Parameters.AddWithValue("@Email", email);
                                    cmd.Parameters.AddWithValue("@RegistrationNumber", regno);
                                    cmd.Parameters.AddWithValue("@Status", status);
                                    cmd.Parameters.AddWithValue("@ID", id);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Successfully Updated");
                                    reloadData();
                                }
                                else
                                {
                                    MessageBox.Show("Please Enter a unique Registration Number");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter a 10-digit long Contact No. (except starting 0)");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a valid Email!!!\nNote: Only gmail's are accepted.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a valid Name!!!");
                    }
                }
                else
                {
                    MessageBox.Show("You can Update only 1 row at a time!!!");
                }
            }
            else
            {
                MessageBox.Show("No row is selected!!!");
            }
        }

        private void reloadData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dt.Columns.Remove("Status");
            dt.Columns.Add("Status", typeof(bool));

            cmd = new SqlCommand("SELECT Status FROM Student", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            sqlDataAdapter.Fill(dt2);

            dt2.Columns.Add("RowIndex", typeof(int));

            // Populate the row index column in dt2
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                dt2.Rows[i]["RowIndex"] = i;
            }

            // Populate the checkbox column based on the values in the DataTable
            foreach (DataRow row in dt2.Rows)
            {
                int rowIndex = (int)row["RowIndex"];
                bool checkboxValue = (int)row["Status"] == 5;
                dt.Rows[rowIndex]["Status"] = checkboxValue;
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                string fname = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
                string lname = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
                string email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                string cno = dataGridView1.CurrentRow.Cells["Contact"].Value.ToString();
                string rgno = dataGridView1.CurrentRow.Cells["RegistrationNumber"].Value.ToString();
                string status = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();
                txtName.Text = fname;
                txtLastName.Text = lname;
                txtEmail.Text = email;
                txtContact.Text = cno;
                txtRegNo.Text = rgno;
                if (status == "True")
                {
                    radioActive.Checked = true;
                    radioInActive.Checked = false;
                }
                else
                {
                    radioInActive.Checked = true;
                    radioActive.Checked = false;
                }
            }
            else
            {
                // More then 1 row selected
            }
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
