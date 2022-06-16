using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShoeShopApp
{
    public partial class MainForm : Form
    {
        private DataBaseShoe dataBaseShoe = new DataBaseShoe();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addPostavshchikButton_Click(object sender, EventArgs e)
        {
            AddPostavshchikForm postavshchikForm = new AddPostavshchikForm(dataBaseShoe);
            postavshchikForm.ShowDialog();
        }

        private void addPostavkaButton_Click(object sender, EventArgs e)
        {
            AddPostavkaForm postavshchikForm = new AddPostavkaForm(dataBaseShoe);
            postavshchikForm.ShowDialog();
        }

        private void addChekButton_Click(object sender, EventArgs e)
        {
            AddChekForm chekForm = new AddChekForm(dataBaseShoe);
            chekForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportSalesForm reportSalesForm = new ReportSalesForm(dataBaseShoe);
            reportSalesForm.ShowDialog();
        }

        private void reportSupplyStatisticsButton_Click(object sender, EventArgs e)
        {
            ReportSupplyStatisticsForm reportSupplyStatisticsForm = new ReportSupplyStatisticsForm(dataBaseShoe);
            reportSupplyStatisticsForm.ShowDialog();
        }

        private void reportShoeClassificationButton_Click(object sender, EventArgs e)
        {
            ReportShoeClassificationForm reportShoeClassificationForm = new ReportShoeClassificationForm(dataBaseShoe);
            reportShoeClassificationForm.ShowDialog();
        }
    }
}
