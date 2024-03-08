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

namespace Main_Project
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
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
    }
}
