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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Main_Project;

namespace Main_Project.Student
{
    public partial class AddStudent : UserControl
    {
        public AddStudent()
        {
            InitializeComponent();
            reloadData();
        }
        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            reloadData();
        }
        private void reloadData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * FROM Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string name = (string)txtName.Text;
            string lastname = (string)txtLastName.Text;
            string email = (string)txtEmail.Text;
            string contact = (string)txtContact.Text;
            string regno = (string)txtRegNo.Text;

            if (name != "" && lastname != "")
            {
                if (email.EndsWith("@gmail.com") && email[0] != '@')
                {
                    if (contact.Length == 10)
                    {
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
                        bool flag = false;
                        foreach (string s in  columnEntries)
                        {
                            if (s == regno)
                            {
                                flag = true;
                            }
                        }
                        if (flag == false && regno != "")
                        {
                            var con = Configuration.getInstance().getConnection();
                            SqlCommand cmd = new SqlCommand("Insert into Student values (@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, @Status)", con);
                            cmd.Parameters.AddWithValue("@FirstName", name);
                            cmd.Parameters.AddWithValue("@LastName", lastname);
                            cmd.Parameters.AddWithValue("@Contact", contact);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@RegistrationNumber", regno);
                            cmd.Parameters.AddWithValue("@Status", 5);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully saved");
                            reloadData();
                            txtName.Clear();
                            txtLastName.Clear();
                            txtEmail.Clear();
                            txtContact.Clear();
                            txtRegNo.Clear();
                            txtName.Focus();
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
    }
}
