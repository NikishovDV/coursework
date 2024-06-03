using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace CourceDB
{
    public partial class SaleForm : Form
    {

        public SaleForm()
        {
            InitializeComponent();
            DB.DisplaySale(dataGridView1);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|Word Files (*.docx)|*.docx|PDF Files (*.pdf)|*.pdf|CSV Files (*.csv)|*.csv";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string extension = Path.GetExtension(filePath).ToLower();

                    if (extension == ".xlsx")
                    {
                        ExportToExcel(filePath);
                    }
                    else if (extension == ".docx")
                    {
                        ExportToWord(filePath);
                    }
                    else if (extension == ".pdf")
                    {
                        ExportToPdf(filePath);
                    }
                    else if (extension == ".csv")
                    {
                        ExportToCsv(filePath);
                    }
                    else
                    {
                        MessageBox.Show("Выберите поддерживаемый формат для экспорта данных.");
                    }
                }
            }
        }

        private void ExportToExcel(string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            int row = 1;
            // Write column headers
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[row, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            row++;

            // Write rows
            foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
            {
                if (!dgvRow.IsNewRow)
                {
                    for (int col = 0; col < dgvRow.Cells.Count; col++)
                    {
                        worksheet.Cells[row, col + 1] = dgvRow.Cells[col].Value?.ToString() ?? "";
                    }
                    row++;
                }
            }

            workbook.SaveAs(filePath);
            workbook.Close();
            excelApp.Quit();

            MessageBox.Show("Данные успешно экспортированы в Excel.");
        }

        private void ExportToWord(string filePath)
        {
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = true;
            Word.Document document = wordApp.Documents.Add();

            Word.Paragraph paragraph = document.Paragraphs.Add();
            paragraph.Range.Text = "Exported Data";
            paragraph.Range.InsertParagraphAfter();

            foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
            {
                if (!dgvRow.IsNewRow)
                {
                    string rowText = "";
                    foreach (DataGridViewCell cell in dgvRow.Cells)
                    {
                        rowText += cell.Value?.ToString() + "\t";
                    }
                    paragraph.Range.Text += rowText + "\n";
                }
            }

            document.SaveAs(filePath);
            document.Close();
            wordApp.Quit();

            MessageBox.Show("Данные успешно экспортированы в Word.");
        }

        private void ExportToPdf(string filePath)
        {
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = false;
            Word.Document document = wordApp.Documents.Add();

            foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
            {
                if (!dgvRow.IsNewRow)
                {
                    string rowText = "";
                    foreach (DataGridViewCell cell in dgvRow.Cells)
                    {
                        rowText += cell.Value?.ToString() + "\t";
                    }
                    document.Content.InsertAfter(rowText + "\n");
                }
            }

            document.SaveAs2(filePath, Word.WdSaveFormat.wdFormatPDF);
            document.Close();
            wordApp.Quit();

            MessageBox.Show("Данные успешно экспортированы в PDF.");
        }

        private void ExportToCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    writer.Write(dataGridView1.Columns[i].HeaderText + ",");
                }
                writer.WriteLine();

                foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
                {
                    if (!dgvRow.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in dgvRow.Cells)
                        {
                            writer.Write(cell.Value?.ToString() + ",");
                        }
                        writer.WriteLine();
                    }
                }
            }

            MessageBox.Show("Данные успешно экспортированы в CSV.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtInDate.Value.Date;
            DateTime endDate = dtOutDate.Value.Date;
            DisplaySaleDate(dataGridView1, startDate, endDate);
        }

        public static void DisplaySaleDate(DataGridView dgv, DateTime startDate, DateTime endDate)
        {
            string sql = "SELECT sale_kod, name.naming AS 'tovar', sale.price AS 'Price', sale.amount AS 'amount', staff.surname AS 'staff', date " +
                         "FROM sale " +
                         "JOIN tovar ON sale.tovar_kod = tovar.kod_tovar " +
                         "JOIN name ON tovar.name = name.name_kod " +
                         "JOIN staff ON staff.staff_kod = sale.staff " +
                         "WHERE date BETWEEN @startDate AND @endDate";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgv.DataSource = tbl;
            }
        }

        public static MySqlConnection GetConnection()
        {
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=brand_shop";
            return new MySqlConnection(connectionString);
        }

        private void dtOutDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonOtm_Click(object sender, EventArgs e)
        {
            DB.DisplaySale(dataGridView1);
        }
    }
}
