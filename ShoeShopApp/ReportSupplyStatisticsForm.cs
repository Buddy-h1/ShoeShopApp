using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace ShoeShopApp
{
    public partial class ReportSupplyStatisticsForm : Form
    {
        private DataBaseShoe dataBaseShoe;
        public ReportSupplyStatisticsForm()
        {
            InitializeComponent();
        }

        public ReportSupplyStatisticsForm(DataBaseShoe dataBaseShoe)
        {
            InitializeComponent();
            this.dataBaseShoe = dataBaseShoe;
            reportNumberTextBox.Text = ReportNumbersManager.GetReportNumber(2).ToString();
            organizationTextBox.Text = "HotCross";
            shopTextBox.Text = "HotCrossShop";
        }

        private class SupplierCount
        {
            public SupplierCount()
            {
                this.id = 0;
                this.supplier = "";
                this.count = 0;
            }
            public SupplierCount(int id, string supplier, int count)
            {
                this.id = id;
                this.supplier = supplier;
                this.count = count;
            }

            public int id;
            public string supplier;
            public int count;
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            ReportNumbersManager.NextReportNumber(2);

            int ReportNumber = Int32.Parse(reportNumberTextBox.Text);
            string startDate = startDateTextBox.Text;
            string finishDate = finishDateTextBox.Text;
            string organization = organizationTextBox.Text;
            string shop = shopTextBox.Text;

            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                //string query = $"SELECT postavshchik.id, postavshchik.nazvanie FROM `postavka` JOIN `postavshchik` ON postavka.postavshchik_id = postavshchik.id WHERE postavka.date BETWEEN \"2022-01-11\" AND \"2022-01-12\" ORDER BY postavshchik.id = 3;";
                string query = $"SELECT postavshchik.id, postavshchik.nazvanie, COUNT(*) FROM `postavka` JOIN `postavshchik` ON postavka.postavshchik_id = postavshchik.id WHERE postavka.date BETWEEN \"{startDate}\" AND \"{finishDate}\" GROUP BY postavshchik.id, postavshchik.nazvanie ORDER BY postavshchik.id;";
                dataBaseShoe.OpenConnection();
                MySqlCommand command = new MySqlCommand(query, dataBaseShoe.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                string path = Environment.CurrentDirectory + "\\templateReportSupplyStatistics.xls";
                Excel.Application excel = new Excel.Application();
                Excel.Workbook wb = excel.Workbooks.Open(path);
                Excel.Worksheet sheet = (Excel.Worksheet)excel.Worksheets.get_Item(1);

                sheet.Cells[2, "B"] = ReportNumber;
                sheet.Cells[3, "B"] = startDate;
                sheet.Cells[3, "E"] = finishDate;
                sheet.Cells[4, "B"] = organization;
                sheet.Cells[5, "B"] = shop;

                sheet.Range["A8:E8"].Copy();
                int pos = 8;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string position = "A" + pos;
                    sheet.Range[position].PasteSpecial(Excel.XlPasteType.xlPasteAll);
                    sheet.Range[position].RowHeight = "15";
                    pos++;
                }
                pos = 8;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    sheet.Range[$"B{pos}:C{pos}"].Merge(Type.Missing);
                    sheet.Range[$"D{pos}:E{pos}"].Merge(Type.Missing);
                    pos++;
                }
                pos = 8;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    sheet.Cells[pos, "A"] = table.Rows[i][0];
                    sheet.Cells[pos, "B"] = table.Rows[i][1];
                    sheet.Cells[pos, "D"] = table.Rows[i][2];
                    pos++;
                }


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
