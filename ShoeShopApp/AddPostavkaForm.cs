using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ShoeShopApp
{
    public partial class AddPostavkaForm : Form
    {
        private DataBaseShoe dataBaseShoe;
        private static int lastDeliveryAmount = 0;

        public static int LastDeliveryAmount
        {
            get
            {
                return lastDeliveryAmount;
            }
            set
            {
                if (value >= 0)
                {
                    lastDeliveryAmount = value;
                }
            }
        }

        public AddPostavkaForm()
        {
            InitializeComponent();
        }

        public AddPostavkaForm(DataBaseShoe dataBaseShoe)
        {
            InitializeComponent();
            this.dataBaseShoe = dataBaseShoe;
        }

        public ListBox GetAllShoeListBox()
        {
            return allShoeListBox;
        }

        private bool CheckData()
        {
            if (postavshchikComboBox.SelectedText.Length > 0)
            {
                MessageBox.Show("Выберите поставщика");
                return false;
            }
            else if (selectedShoeListBox.Items.Count == 0)
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

        private void addShoebutton_Click(object sender, EventArgs e)
        {
            AddShoeForm addShoeForm = new AddShoeForm(dataBaseShoe, this);
            addShoeForm.ShowDialog();
        }

        private void AddPostavkaForm_Shown(object sender, EventArgs e)
        {
            dataBaseShoe.UpdateListAllShoe(allShoeListBox);
            dataBaseShoe.PrintAllShoe(dataBaseShoe.GetDateTable("postavshchik"), postavshchikComboBox);
        }

        private void allShoeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = allShoeListBox.SelectedIndex;
            if (index == -1) return;
            string indexInDataBase = allShoeListBox.Items[index].ToString().Substring(0, 12).Trim();
            if (!dataBaseShoe.SearchListBoxForKey(selectedShoeListBox, indexInDataBase))
            {
                DeliveryAmountForm inputAmountForm = new DeliveryAmountForm();
                inputAmountForm.ShowDialog();
                string infoShoe = allShoeListBox.Items[index].ToString();
                string infoShoeOne = infoShoe.Substring(0, 70);
                string infoShoeTwo = " " + lastDeliveryAmount.ToString();
                infoShoeTwo = infoShoeTwo.PadRight(12);
                infoShoeTwo += "\t|";
                string infoShoeThree = infoShoe.Substring(84);
                selectedShoeListBox.Items.Add(infoShoeOne + infoShoeTwo + infoShoeThree);
            }
            else return;
        }

        private void selectedShoeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = selectedShoeListBox.SelectedIndex;
            if (index == -1) return;
            selectedShoeListBox.Items.RemoveAt(index);
        }

        private void addPostavkabutton_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                int idPostavshchik;
                string str = postavshchikComboBox.Text;
                str = str.Substring(0, 12).Trim();


                idPostavshchik = Int32.Parse(str);
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
                    command.CommandText = $"INSERT INTO `postavka` (`id`, `postavshchik_id`, `date`, `stoimost`) VALUES (NULL, '{idPostavshchik}', '{date}', '{stoimost}');";
                    command.ExecuteNonQuery();


                    dataBaseShoe.OpenConnection();
                    for (int i = 0; i < idAmountList.Count; i++)
                    {
                        command.CommandText = $"UPDATE obuv SET kolichestvo = (kolichestvo + {idAmountList[i].amount}) WHERE id = {idAmountList[i].id};";
                        command.ExecuteNonQuery();
                    }


                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    dataBaseShoe.OpenConnection();
                    command.CommandText = "SELECT * FROM postavka WHERE id=LAST_INSERT_ID();";
                    DataTable table = new DataTable();
                    adapter.SelectCommand = command;
                    command.ExecuteNonQuery();
                    adapter.Fill(table);
                    int currentPostavkaId = 0;
                    using (DataTableReader dr = table.CreateDataReader())
                    {
                        while (dr.Read())
                        {
                            currentPostavkaId = Int32.Parse(dr.GetValue(0).ToString());
                        }
                    }


                    dataBaseShoe.OpenConnection();
                    for (int i = 0; i < idAmountList.Count; i++)
                    {
                        command.CommandText = $"INSERT INTO `postavka_obuv` (`id`, `postavka_id`, `obuv_id`, `kolichestvo`) VALUES (NULL, '{currentPostavkaId}', '{idAmountList[i].id}', '{idAmountList[i].amount}');";
                        command.ExecuteNonQuery();
                    }

                    dataBaseShoe.OpenConnection();
                    dataBaseShoe.GetTransaction().Commit();

                    MessageBox.Show("Записи успешно добавлены/обновлены");
                    dataBaseShoe.UpdateListAllShoe(allShoeListBox);
                    postavshchikComboBox.SelectedIndex = -1;
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
