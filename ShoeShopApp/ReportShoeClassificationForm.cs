using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace ShoeShopApp
{
    public partial class ReportShoeClassificationForm : Form
    {
        private DataBaseShoe dataBaseShoe;

        public ReportShoeClassificationForm(DataBaseShoe dataBaseShoe)
        {
            InitializeComponent();
            this.dataBaseShoe = dataBaseShoe;
            reportNumberTextBox.Text = ReportNumbersManager.GetReportNumber(3).ToString();
            organizationTextBox.Text = "HotCross";
            shopTextBox.Text = "HotCrossShop";
        }

        public ReportShoeClassificationForm()
        {
            InitializeComponent();
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            ReportNumbersManager.NextReportNumber(3);

            int ReportNumber = Int32.Parse(reportNumberTextBox.Text);
            string organization = organizationTextBox.Text;
            string shop = shopTextBox.Text;
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string query = $"SELECT obuv.kategoriya, COUNT(*) FROM `obuv` GROUP BY obuv.kategoriya;";
                dataBaseShoe.OpenConnection();
                MySqlCommand command = new MySqlCommand(query, dataBaseShoe.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                string path = Environment.CurrentDirectory + "\\templateReportShoeClassification.xls";
                Excel.Application excel = new Excel.Application();
                Excel.Workbook wb = excel.Workbooks.Open(path);
                Excel.Worksheet sheet = (Excel.Worksheet)excel.Worksheets.get_Item(1);

                sheet.Cells[2, "B"] = ReportNumber;
                sheet.Cells[5, "B"] = organization;
                sheet.Cells[6, "B"] = shop;

                sheet.Range["A9:C9"].Copy();
                int pos = 9;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string position = "A" + pos;
                    sheet.Range[position].PasteSpecial(Excel.XlPasteType.xlPasteAll);
                    sheet.Range[position].RowHeight = "15";
                    pos++;
                }
                pos = 9;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    sheet.Range[$"A{pos}:B{pos}"].Merge(Type.Missing);
                    pos++;
                }
                pos = 9;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    sheet.Cells[pos, "A"] = table.Rows[i][0];
                    sheet.Cells[pos, "C"] = table.Rows[i][1];
                    pos++;
                }

                table = new DataTable();
                query = $"SELECT obuv.pol, COUNT(*) FROM `obuv` GROUP BY obuv.pol";
                dataBaseShoe.OpenConnection();
                command = new MySqlCommand(query, dataBaseShoe.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                sheet.Cells[8, "F"] = table.Rows[0][1];
                sheet.Cells[9, "F"] = table.Rows[1][1];

                string pathSave = "";
                saveFileDialog.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathSave = saveFileDialog.FileName;
                }
                excel.Application.ActiveWorkbook.SaveAs(pathSave);

                CloseExcel(excel);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка получения данных.");
            }
        }

        private void CloseExcel(Excel.Application excel)
        {
            foreach (Excel.Workbook _workbook in excel.Workbooks)
            {
                _workbook.Close(0);
            }

            excel.Quit();
            excel = null;
            var process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (var p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName))
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }
    }
}
