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
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
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

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Student values (@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, @Status)", con);
            cmd.Parameters.AddWithValue("@FirstName", name);
            cmd.Parameters.AddWithValue("@LastName", lastname);
            cmd.Parameters.AddWithValue("@Contact", contact);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@RegistrationNumber", regno);
            cmd.Parameters.AddWithValue("@Status", 1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }
    }
}
