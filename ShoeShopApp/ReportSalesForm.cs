using System.Windows.Forms;
using System.IO;
using System;
using System.Data;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;


namespace ShoeShopApp
{
    public partial class ReportSalesForm : Form
    {
        private DataBaseShoe dataBaseShoe;
        private List<MonthTitle> monthTitles = new List<MonthTitle>();
        private string[,] dataTable;
        private int countRows = 0;
        private int countColumns = 0;
        public ReportSalesForm()
        {
            InitializeComponent();
        }

        public ReportSalesForm(DataBaseShoe dataBaseShoe)
        {
            InitializeComponent();
            this.dataBaseShoe = dataBaseShoe;

            monthTitles.Add(new MonthTitle("Января"));
            monthTitles.Add(new MonthTitle("Февраля"));
            monthTitles.Add(new MonthTitle("Марта"));
            monthTitles.Add(new MonthTitle("Апреля"));
            monthTitles.Add(new MonthTitle("Мая"));
            monthTitles.Add(new MonthTitle("Июня"));
            monthTitles.Add(new MonthTitle("Июля"));
            monthTitles.Add(new MonthTitle("Августа"));
            monthTitles.Add(new MonthTitle("Сентября"));
            monthTitles.Add(new MonthTitle("Октября"));
            monthTitles.Add(new MonthTitle("Ноября"));
            monthTitles.Add(new MonthTitle("Декабря"));

            reportNumberTextBox.Text = ReportNumbersManager.GetReportNumber(1).ToString();
            dataTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            organizationTextBox.Text = "HotCross";
            shopTextBox.Text = "HotCrossShop";
            transmitterTextBox.Text = "Бурова Л. В.";
        }

        private class MonthTitle
        {
            public MonthTitle(string title)
            {
                this.title = title;
            }

            public string title;
        }

        private void DateCountSuppliesSales(string field, string data, int row, int row2)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string query = $"SELECT obuv.id, {field}_obuv.kolichestvo FROM `obuv` JOIN `{field}_obuv` ON obuv.id={field}_obuv.obuv_id JOIN `{field}` ON {field}_obuv.{field}_id={field}.id WHERE {field}.date BETWEEN DATE_SUB(\"{data}\", INTERVAL 30 DAY) AND \"{data}\" ORDER BY obuv.id;";
            dataBaseShoe.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, dataBaseShoe.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0) return;
            int currentId = Int32.Parse(table.Rows[0][0].ToString());
            int currentCountShoes = 0;
            for (int i = 0; i < table.Rows.Count + 1; i++)
            {
                if (i == table.Rows.Count)
                {
                    int idInDateTable = 0;
                    for (int j = 0; j < countRows; j++)
                    {
                        if (Int32.Parse(dataTable[j, 0]) == currentId)
                        {
                            idInDateTable = j;
                            break;
                        }
                    }
                    dataTable[idInDateTable, row] = currentCountShoes.ToString();
                }
                else if (Int32.Parse(table.Rows[i][0].ToString()) == currentId)
                {
                    currentCountShoes += Int32.Parse(table.Rows[i][1].ToString());
                }
                else
                {
                    int idInDateTable = 0;
                    for (int j = 0; j < countRows; j++)
                    {
                        if (Int32.Parse(dataTable[j, 0]) == currentId)
                        {
                            idInDateTable = j;
                            break;
                        }
                    }
                    currentId = Int32.Parse(table.Rows[i][0].ToString());
                    dataTable[idInDateTable, row] = currentCountShoes.ToString();
                    currentCountShoes = Int32.Parse(table.Rows[i][1].ToString());
                }
            }

            for (int i = 0; i < countRows; i++)
            {
                dataTable[i, row2] = (Int32.Parse(dataTable[i, row]) * Int32.Parse(dataTable[i, 3])).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportNumbersManager.NextReportNumber(1);

            int ReportNumber = Int32.Parse(reportNumberTextBox.Text);
            string data = dataTextBox.Text;
            string organization = organizationTextBox.Text;
            string shop = shopTextBox.Text;
            string transmitter = transmitterTextBox.Text;

            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string query = $"SELECT id, naimenovanie, cena_prodazhi, kolichestvo FROM `obuv`;";
                dataBaseShoe.OpenConnection();
                MySqlCommand command = new MySqlCommand(query, dataBaseShoe.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataTable = new string[table.Rows.Count, 12];
                countRows = table.Rows.Count;
                countColumns = 12;

                for (int i = 0; i < countRows; i++)
                {
                    for (int j = 0; j < countColumns; j++)
                    {
                        dataTable[i, j] = "0";
                    }
                }

                for (int i = 0; i < countRows; i++)
                {
                    dataTable[i, 0] = table.Rows[i][0].ToString();
                    dataTable[i, 1] = table.Rows[i][1].ToString();
                    dataTable[i, 2] = "шт.";
                    dataTable[i, 3] = table.Rows[i][2].ToString();
                    dataTable[i, 10] = table.Rows[i][3].ToString();
                    dataTable[i, 11] = (Int32.Parse(dataTable[i, 10]) * Int32.Parse(table.Rows[i][2].ToString())).ToString();
                }

                DateCountSuppliesSales("postavka", data, 6, 7);
                DateCountSuppliesSales("chek", data, 8, 9);

                for (int i = 0; i < countRows; i++)
                {
                    dataTable[i, 4] = (Int32.Parse(dataTable[i, 10]) - Int32.Parse(dataTable[i, 6]) + Int32.Parse(dataTable[i, 8])).ToString();
                    dataTable[i, 5] = (Int32.Parse(dataTable[i, 4]) * Int32.Parse(dataTable[i, 3])).ToString();
                }

                string path = Environment.CurrentDirectory + "\\templateReportSales.xls";
                Excel.Application excel = new Excel.Application();
                Excel.Workbook wb = excel.Workbooks.Open(path);
                Excel.Worksheet sheet = (Excel.Worksheet)excel.Worksheets.get_Item(1);

                sheet.Cells[4, "I"] = ReportNumber;
                sheet.Cells[6, "G"] = data.Substring(8) + " " + monthTitles[Int32.Parse(data.Substring(5, 2)) - 1].title;
                sheet.Cells[6, "L"] = data.Substring(2, 2);
                sheet.Cells[7, "T"] = data.Substring(8);
                sheet.Cells[7, "V"] = data.Substring(5, 2);
                sheet.Cells[7, "W"] = data.Substring(2, 2);
                sheet.Cells[8, "B"] = organization;
                sheet.Cells[9, "B"] = shop;
                sheet.Cells[10, "B"] = transmitter;

                //Разметка отчета
                sheet.Range["A17:W17"].Copy();
                sheet.Range["A1"].PasteSpecial(Excel.XlPasteType.xlPasteAll);
                sheet.Range["A17:W17"].EntireRow.Clear();
                sheet.Range["A16:W16"].Copy();
                int pos = 16;
                for (int i = 0; i < countRows; i++)
                {
                    string position = "A" + pos;
                    sheet.Range[position].PasteSpecial(Excel.XlPasteType.xlPasteAll);
                    sheet.Range[position].RowHeight = "15";
                    pos++;
                }
                sheet.Range["A1:W1"].Copy();
                sheet.Range["A" + pos].PasteSpecial(Excel.XlPasteType.xlPasteAll);
                sheet.Range["A1:W1"].EntireRow.Clear();

                pos = 16;
                for (int i = 0; i < countRows; i++)
                {
                    sheet.Range[$"F{pos}:G{pos}"].Merge(Type.Missing);
                    sheet.Range[$"H{pos}:I{pos}"].Merge(Type.Missing);
                    sheet.Range[$"J{pos}:M{pos}"].Merge(Type.Missing);
                    sheet.Range[$"O{pos}:Q{pos}"].Merge(Type.Missing);
                    sheet.Range[$"R{pos}:T{pos}"].Merge(Type.Missing);
                    sheet.Range[$"U{pos}:W{pos}"].Merge(Type.Missing);
                    pos++;
                }

                //Заполнение
                pos = 16;
                for (int i = 0; i < countRows; i++)
                {
                    sheet.Cells[pos, "A"] = dataTable[i, 0];
                    sheet.Cells[pos, "B"] = dataTable[i, 1];
                    sheet.Cells[pos, "C"] = dataTable[i, 2];
                    sheet.Cells[pos, "D"] = dataTable[i, 3];
                    sheet.Cells[pos, "E"] = dataTable[i, 4];
                    sheet.Cells[pos, "F"] = dataTable[i, 5];
                    sheet.Cells[pos, "H"] = dataTable[i, 6];
                    sheet.Cells[pos, "J"] = dataTable[i, 7];
                    sheet.Cells[pos, "N"] = dataTable[i, 8];
                    sheet.Cells[pos, "O"] = dataTable[i, 9];
                    sheet.Cells[pos, "R"] = dataTable[i, 10];
                    sheet.Cells[pos, "U"] = dataTable[i, 11];
                    pos++;
                }

                string[] result = new string[8] { "0", "0", "0", "0", "0", "0", "0", "0" };

                for (int i = 0; i < countRows; i++)
                {
                    result[0] = (Int32.Parse(result[0]) + Int32.Parse(dataTable[i, 4])).ToString();
                    result[1] = (Int32.Parse(result[1]) + Int32.Parse(dataTable[i, 5])).ToString();
                    result[2] = (Int32.Parse(result[2]) + Int32.Parse(dataTable[i, 6])).ToString();
                    result[3] = (Int32.Parse(result[3]) + Int32.Parse(dataTable[i, 7])).ToString();
                    result[4] = (Int32.Parse(result[4]) + Int32.Parse(dataTable[i, 8])).ToString();
                    result[5] = (Int32.Parse(result[5]) + Int32.Parse(dataTable[i, 9])).ToString();
                    result[6] = (Int32.Parse(result[6]) + Int32.Parse(dataTable[i, 10])).ToString();
                    result[7] = (Int32.Parse(result[7]) + Int32.Parse(dataTable[i, 11])).ToString();
                }

                sheet.Cells[pos, "E"] = result[0];
                sheet.Cells[pos, "F"] = result[1];
                sheet.Cells[pos, "H"] = result[2];
                sheet.Cells[pos, "J"] = result[3];
                sheet.Cells[pos, "N"] = result[4];
                sheet.Cells[pos, "O"] = result[5];
                sheet.Cells[pos, "R"] = result[6];
                sheet.Cells[pos, "U"] = result[7];

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
