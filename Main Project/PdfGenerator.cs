using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

//using PdfSharp.Pdf;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Main_Project
{
    public class PdfGenerator
    {
        public static void PrintDataToDocument(DataTable dataTable, string filename, string tableHeader)
        {
            try
            {
                // Create a new PDF document
                string path = String.Concat(@"C:\Users\HP\Desktop\", filename);
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                Paragraph heading = new Paragraph("Project Report").SetFontSize(16);
                Paragraph heading2 = new Paragraph("Prepared by Saqlain Mansab").SetFontSize(12);
                Paragraph heading3 = new Paragraph(tableHeader).SetTextAlignment(TextAlignment.CENTER);
                document.Add(heading);
                document.Add(heading2);
                document.Add(heading3);

                // Create a table with as many columns as there are in the DataTable
                iText.Layout.Element.Table table = new iText.Layout.Element.Table(dataTable.Columns.Count, true);

                // Set table properties
                table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                table.SetWidth(UnitValue.CreatePercentValue(100));

                // Add column headers to the table
                foreach (DataColumn column in dataTable.Columns)
                {
                    //table.AddHeaderCell(column.ColumnName);
                    Cell cell = new Cell().Add(new Paragraph(column.ColumnName)).SetBold();  //Bold Header
                    cell.SetHeight(20);
                    cell.SetFontSize(10);
                    table.AddCell(cell);
                }

                // Add data rows to the table
                foreach (DataRow row in dataTable.Rows)
                {
                    //table.StartNewRow().SetFixedHeight(30);          // fix row side
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        Cell cell = new Cell().Add(new Paragraph(row[column.ColumnName].ToString())).SetFontSize(8);     // Set font size
                        cell.SetHeight(20);               //substitute to set height
                                                          //cell.SetMinWidth(Math.Min(50, row[column.ColumnName].ToString().Length * 5));       // Adjust the multiplier (5) as needed
                        cell.SetMinWidth(50);
                        cell.SetMaxWidth(100);
                        table.AddCell(cell);
                    }
                }
                table.SetWidth(UnitValue.CreatePercentValue(100));
                // Add the table to the document
                document.Add(table);

                // Close the document
                document.Close();

                MessageBox.Show("PDF report generated successfully!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static string ShowInputDialog(string prompt)
        {
            Form promptForm = new Form()
            {
                Width = 500,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "File Name",
                StartPosition = FormStartPosition.CenterScreen
            };
            System.Windows.Forms.Label textLabel = new System.Windows.Forms.Label() { Left = 50, Top = 20, Width = 400, Text = prompt };
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox() { Left = 50, Top = 55, Width = 400 };
            System.Windows.Forms.Button confirmation = new System.Windows.Forms.Button() { Text = "OK", Left = 350, Width = 100, Top = 90, Height = 30, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { promptForm.Close(); };
            promptForm.Controls.Add(textBox);
            promptForm.Controls.Add(confirmation);
            promptForm.Controls.Add(textLabel);
            promptForm.AcceptButton = confirmation;

            return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
