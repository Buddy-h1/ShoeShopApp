using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ShoeShopApp
{
    public partial class AddChekForm : Form
    {
        private DataBaseShoe dataBaseShoe;
        private static int lastSoldAmount = 1;

        public static int LastSoldAmount
        {
            get
            {
                return lastSoldAmount;
            }
            set
            {
                if (value >= 1)
                {
                    lastSoldAmount = value;
                }
            }
        }

        public AddChekForm()
        {
            InitializeComponent();
        }

        public AddChekForm(DataBaseShoe dataBaseShoe)
        {
            InitializeComponent();
            this.dataBaseShoe = dataBaseShoe;
        }

        private void AddChekForm_Shown(object sender, EventArgs e)
        {
            dataBaseShoe.UpdateListAllShoe(allShoeListBox);
        }

        private void selectedShoeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = selectedShoeListBox.SelectedIndex;
            if (index == -1) return;
            selectedShoeListBox.Items.RemoveAt(index);
        }

        private void allShoeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = allShoeListBox.SelectedIndex;
            if (index == -1) return;
            string indexInDataBase = allShoeListBox.Items[index].ToString().Substring(0, 12).Trim();
            if (!dataBaseShoe.SearchListBoxForKey(selectedShoeListBox, indexInDataBase))
            {
                SoldAmountForm inputAmountForm = new SoldAmountForm();
                inputAmountForm.ShowDialog();
                string infoShoe = allShoeListBox.Items[index].ToString();
                string infoShoeOne = infoShoe.Substring(0, 70);
                string infoShoeTwo = " " + lastSoldAmount.ToString();
                infoShoeTwo = infoShoeTwo.PadRight(12);
                infoShoeTwo += "\t|";
                string infoShoeThree = infoShoe.Substring(84);
                selectedShoeListBox.Items.Add(infoShoeOne + infoShoeTwo + infoShoeThree);
            }
            else return;
        }

        private bool CheckData()
        {
            if (selectedShoeListBox.Items.Count == 0)
            {
                MessageBox.Show("Выберите обувь");
                return false;
            }
            else if (dateTextBox.Text == "")
            {
                MessageBox.Show("Введите дату");
                return false;
            }
            else if (stoimostTextBox.Text == "")
            {
                MessageBox.Show("Введите Стоимость");
                return false;
            }
            return true;
        }

        private void addChekbutton_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string date = dateTextBox.Text;
                int stoimost = Int32.Parse(stoimostTextBox.Text);
                List<DataBaseShoe.IdAmount> idAmountList = new List<DataBaseShoe.IdAmount>();

                for (int i = 0; i < selectedShoeListBox.Items.Count; i++)
                {
                    DataBaseShoe.IdAmount idAmount = new DataBaseShoe.IdAmount();
                    idAmount.id = Int32.Parse(selectedShoeListBox.Items[i].ToString().Substring(0, 12).Trim());
                    string str2 = selectedShoeListBox.Items[i].ToString();
                    str2 = str2.Substring(70);
                    str2 = str2.Substring(0, 12).Trim();
                    idAmount.amount = Int32.Parse(str2);
                    idAmountList.Add(idAmount);
                }

                //Добавление в БД
                try
                {
                    MySqlCommand command = dataBaseShoe.GetConnection().CreateCommand();
                    command.Connection = dataBaseShoe.GetConnection();
                    dataBaseShoe.StartNewTransaction();
                    command.Transaction = dataBaseShoe.GetTransaction();


                    dataBaseShoe.OpenConnection();
                    command.CommandText = $"INSERT INTO `chek` (`id`, `date`, `stoimost`) VALUES (NULL, '{date}', '{stoimost}');";
                    command.ExecuteNonQuery();


                    dataBaseShoe.OpenConnection();
                    for (int i = 0; i < idAmountList.Count; i++)
                    {
                        command.CommandText = $"UPDATE obuv SET kolichestvo = (kolichestvo - {idAmountList[i].amount}) WHERE id = {idAmountList[i].id};";
                        command.ExecuteNonQuery();
                    }


                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    dataBaseShoe.OpenConnection();
                    command.CommandText = "SELECT * FROM chek WHERE id=LAST_INSERT_ID();";
                    DataTable table = new DataTable();
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    int currentChekId = 0;
                    using (DataTableReader dr = table.CreateDataReader())
                    {
                        while (dr.Read())
                        {
                            currentChekId = Int32.Parse(dr.GetValue(0).ToString());
                        }
                    }


                    dataBaseShoe.OpenConnection();
                    for (int i = 0; i < idAmountList.Count; i++)
                    {
                        command.CommandText = $"INSERT INTO `chek_obuv` (`id`, `chek_id`, `obuv_id`, `kolichestvo`) VALUES (NULL, '{currentChekId}', '{idAmountList[i].id}', '{idAmountList[i].amount}');";
                        command.ExecuteNonQuery();
                    }

                    dataBaseShoe.OpenConnection();
                    dataBaseShoe.GetTransaction().Commit();

                    MessageBox.Show("Записи успешно добавлены/обновлены");
                    dataBaseShoe.UpdateListAllShoe(allShoeListBox);
                    dateTextBox.Text = "";
                    stoimostTextBox.Text = "";
                    selectedShoeListBox.Items.Clear();
                }
                catch (Exception)
                {
                    dataBaseShoe.OpenConnection();
                    dataBaseShoe.GetTransaction().Rollback();
                    MessageBox.Show("Запись не была добавлена :(");
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            dataBaseShoe.UpdateListAllShoe(allShoeListBox);
        }
    }
}
