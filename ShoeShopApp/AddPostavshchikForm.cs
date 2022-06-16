using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShoeShopApp
{
    public partial class AddPostavshchikForm : Form
    {

        private DataBaseShoe dataBaseShoe;

        public AddPostavshchikForm()
        {
            InitializeComponent();
        }

        public AddPostavshchikForm(DataBaseShoe dataBaseShoe)
        {
            InitializeComponent();
            this.dataBaseShoe = dataBaseShoe;
        }

        private bool CheckData(string str)
        {
            if (str.Length > 100)
            {
                MessageBox.Show("Длина строки привысила 100 символов");
                return false;
            }
            if (str == "")
            {
                MessageBox.Show("Строки не должны быть пустыми");
                return false;
            }
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string nazvanie = nazvanieTextBox.Text;
            string adres = adresTextBox.Text;
            string rukovodstvo = rukovodstvoTextBox.Text;
            string nomerTelefona = nomerTelefonaTextBox.Text;
            if (CheckData(nazvanie) && CheckData(adres) && CheckData(rukovodstvo) && CheckData(nomerTelefona)) {
                string query = $"INSERT INTO postavshchik (nazvanie, adres, rukovodstvo, nomer_telefona) VALUES ('{nazvanie}','{adres}','{rukovodstvo}','{nomerTelefona}');";

                dataBaseShoe.OpenConnection();

                MySqlCommand command = new MySqlCommand(query, dataBaseShoe.GetConnection());

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена!");
                    nazvanieTextBox.Text = "";
                    adresTextBox.Text = "";
                    rukovodstvoTextBox.Text = "";
                    nomerTelefonaTextBox.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Запись не была добавлена :(");
                }
            }
            else return;
        }
    }
}
