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
            int rowIndex = -1;  
            rowIndex = dataGridView1.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                string name = (string)txtName.Text;
                string lastname = (string)txtLastName.Text;
                string email = (string)txtEmail.Text;
                string contact = (string)txtContact.Text;
                string regno = (string)txtRegNo.Text;

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Student values (@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, @Status)", con);
                cmd.Parameters.AddWithValue("@FirstName", name);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@RegistrationNumber", regno);
                cmd.Parameters.AddWithValue("@Status", 1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
                reloadData();
            }
            else
            {
                MessageBox.Show("No Row is Selected!!!");
            }
        }

        private void reloadData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                //int selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RegistrationNumber"].Value);
                MessageBox.Show("RowIndex = @rowIndex \n RegistrationNumber ");
            }
            else
            {
                // No row is selected
            }
        }
    }
}
