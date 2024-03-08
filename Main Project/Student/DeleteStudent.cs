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
using System.Xml.Linq;
using Main_Project.Student;

namespace Main_Project.Student
{
    public partial class DeleteStudent : UserControl
    {
        public DeleteStudent()
        {
            InitializeComponent();
            reloadData();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE ID = @ID", con);
                    //cmd.Parameters.AddWithValue("@FirstName", name);
                    //cmd.Parameters.AddWithValue("@LastName", lastname);
                    //cmd.Parameters.AddWithValue("@Contact", contact);
                    //cmd.Parameters.AddWithValue("@Email", email);
                    //cmd.Parameters.AddWithValue("@RegistrationNumber", regno);
                    //cmd.Parameters.AddWithValue("@Status", 1);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");
                    reloadData();
                }
                else
                {
                    MessageBox.Show("Only One Row can be deleted at a time!!!");
                }
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
    }
}
