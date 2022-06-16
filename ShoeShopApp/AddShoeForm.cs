using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ShoeShopApp
{
    public partial class AddShoeForm : Form
    {
        private DataBaseShoe dataBaseShoe;
        private AddPostavkaForm postavkaForm;
        public AddShoeForm()
        {
            InitializeComponent();
        }

        public AddShoeForm(DataBaseShoe dataBaseShoe, AddPostavkaForm postavkaForm)
        {
            InitializeComponent();
            this.dataBaseShoe = dataBaseShoe;
            this.postavkaForm = postavkaForm;
        }

        private bool CheckData()
        {
            if (naimenovanieTextBox.Text.Length > 100)
            {
                MessageBox.Show("Длина строки <<Наименование>> привысила 100 символов");
                return false;
            }
            else if (polTextBox.Text.Length > 7)
            {
                MessageBox.Show("Длина строки <<Пол>> привысила 7 символов");
                return false;
            }
            else if (kategoriyaTextBox.Text.Length > 50)
            {
                MessageBox.Show("Длина строки <<Категория>> привысила 50 символов");
                return false;
            }
            else if (razmerTextBox.Text.Length > 10)
            {
                MessageBox.Show("Длина строки <<Размер>> привысила 50 символов");
                return false;
            }
            else if (naimenovanieTextBox.Text == "" || polTextBox.Text == "" || kategoriyaTextBox.Text == "" ||
                razmerTextBox.Text == "" || kolichestvoTextBox.Text == "" || cenaProdazhiTextBox.Text == "")
            {
                MessageBox.Show("Строки не должны быть пустыми");
                return false;
            }
            return true;
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            if (CheckData())
            {
                string naimenovaniee = naimenovanieTextBox.Text;
                string pol = polTextBox.Text;
                string kategoriya = kategoriyaTextBox.Text;
                string razmer = razmerTextBox.Text;
                int kolichestvo = Int32.Parse(kolichestvoTextBox.Text);
                int cenaProdazhi = Int32.Parse(cenaProdazhiTextBox.Text);
                string query = $"INSERT INTO obuv (naimenovanie, pol, kategoriya, razmer, kolichestvo, cena_prodazhi) VALUES ('{naimenovaniee}','{pol}','{kategoriya}','{razmer}','{kolichestvo}','{cenaProdazhi}');";

                dataBaseShoe.OpenConnection();

                MySqlCommand command = new MySqlCommand(query, dataBaseShoe.GetConnection());
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена!");
                    dataBaseShoe.UpdateListAllShoe(postavkaForm.GetAllShoeListBox());
                    naimenovanieTextBox.Text = "";
                    polTextBox.Text = "";
                    kategoriyaTextBox.Text = "";
                    razmerTextBox.Text = "";
                    kolichestvoTextBox.Text = "";
                    cenaProdazhiTextBox.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Запись не была добавлена :(");
                }
            }
        }
    }
}
