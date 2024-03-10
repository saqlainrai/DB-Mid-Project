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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Main_Project.CLO
{
    public partial class AddCLO : UserControl
    {
        public AddCLO()
        {
            InitializeComponent();
            reloadData();
        }
        private void reloadData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand c = new SqlCommand("SELECT * FROM Clo", con);
            SqlDataAdapter dat = new SqlDataAdapter(c);
            DataTable d = new DataTable();
            dat.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    try
                    {
                        string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Clo WHERE ID = @ID", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted");
                        reloadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    string clo = (string)txtCLO.Text;
                    var c = Configuration.getInstance().getConnection();
                    SqlCommand cm = new SqlCommand("SELECT Name FROM Clo", c);
                    SqlDataAdapter d = new SqlDataAdapter(cm);
                    DataTable dataTable = new DataTable();
                    d.Fill(dataTable);
                    List<string> columnEntries = new List<string>();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        columnEntries.Add(row["Name"].ToString());
                    }
                    bool flag = false;
                    foreach (string s in columnEntries)
                    {
                        if (s == clo)
                        {
                            flag = true;
                        }
                    }
                    if (clo != "" && !flag)
                    {
                        string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("UPDATE Clo SET Name = @Name, DateUpdated = GETDATE() WHERE ID = @ID", con);
                        cmd.Parameters.AddWithValue("@Name", clo);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated");
                        reloadData();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a Valid Name of CLO!!!");
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

        private void button3_Click(object sender, EventArgs e)
        {
            string clo = txtCLO.Text;
            var c = Configuration.getInstance().getConnection();
            SqlCommand cm = new SqlCommand("SELECT Name FROM Clo", c);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dataTable = new DataTable();
            d.Fill(dataTable);
            List<string> columnEntries = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                columnEntries.Add(row["Name"].ToString());
            }
            bool flag = false;
            foreach (string s in columnEntries)
            {
                if (s == clo)
                {
                    flag = true;
                }
            }
            if (clo != "" && !flag)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Clo values (@name, GETDATE(), GETDATE())", con);
                cmd.Parameters.AddWithValue("@name", clo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                reloadData();
                txtCLO.Clear();
                txtCLO.Focus();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Name of CLO!!!");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtCLO.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
        }
    }
}
