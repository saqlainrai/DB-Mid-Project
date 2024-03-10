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
using static iText.Signatures.LtvVerification;

namespace Main_Project
{
    public partial class Rubrics : UserControl
    {
        public Rubrics()
        {
            InitializeComponent();
            reloadData1();
            reloadData2();
            fillComboBoxs();
            txtDetails.Focus();
        }

        private void fillComboBoxs()
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

            query = "SELECT CONCAT(c.Id,'-',c.Name) FROM CLO c";
            cmd = new SqlCommand(query, con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboCLO.Items.Add(reader.GetString(0));
                }
            }
            this.comboCLO.SelectedIndex = 0;
            this.comboRubric.SelectedIndex = 0;
        }

        private void reloadData1()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Rubric", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void reloadData2()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM RubricLevel", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }
        private void Rubrics_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string details = txtDetails.Text;
            int cloID = int.Parse(comboCLO.Text.Split('-')[0]);
            if (details != "")
            {
                var con1 = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("SELECT TOP(1) Id FROM RubricLevel ORDER BY Id DESC", con1);
                int previousID = (int)cmd1.ExecuteScalar();

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Rubric Values (@Id, @Details, @cloID)", con);
                cmd.Parameters.AddWithValue("@Id", previousID + 1);
                cmd.Parameters.AddWithValue("@Details", details);
                cmd.Parameters.AddWithValue("@cloID", cloID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                reloadData1();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Details of the Rubric!!!");
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            int rubricID = int.Parse(comboRubric.Text.Split('-')[0]);
            string details = txtDetailsR.Text;
            int level = (int)intLevel.Value;

            if (details != "")
            {
                var con1 = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("SELECT TOP(1) Id FROM RubricLevel ORDER BY Id DESC", con1);
                int previousID = (int)cmd1.ExecuteScalar();

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into RubricLevel Values (@Id, @RubricID, @Details, @Level)", con);
                cmd.Parameters.AddWithValue("@Id", previousID + 1);
                cmd.Parameters.AddWithValue("@RubricID", rubricID);
                cmd.Parameters.AddWithValue("@Details", details);
                cmd.Parameters.AddWithValue("@Level", level);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                reloadData2();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Details of the Rubric Level!!!");
            }
            this.comboRubric.SelectedIndex = 0;
            txtDetailsR.Clear();
            intLevel.Value = 0;
        }
    }
}
