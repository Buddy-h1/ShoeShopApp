using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShoeShopApp
{
    public class DataBaseShoe
    {
        private MySqlConnection connection = new MySqlConnection("server=remotemysql.com;port=3306;username=fhPLGLQp7U;password=AUQBI188H6;database=fhPLGLQp7U;ConnectionReset=True");
        private MySqlTransaction transaction;

        public DataBaseShoe()
        {
            StartNewTransaction();
        }

        public MySqlTransaction GetTransaction()
        {
            return transaction;
        }

        public void StartNewTransaction()
        {
            CloseConnection();
            OpenConnection();
            transaction = connection.BeginTransaction();
        }


        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public class IdAmount
        {
            public int id = 0;
            public int amount = 0;
        }

        public void UpdateListAllShoe(ListBox listBox)
        {
            listBox.Items.Clear();
            PrintAllShoe(GetDateTable("obuv"), listBox);
        }

        public DataTable GetDateTable(string nameTable)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string query = $"SELECT * FROM `{nameTable}`";
            OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            adapter.SelectCommand = command;
            try
            {
                adapter.Fill(table);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка получения данных. Обновите список.");
            }
            return table;
        }

        public void PrintAllShoe(DataTable dt, ListBox listBox)
        {
            string obuvStr = "";
            using (DataTableReader dr = dt.CreateDataReader())
            {
                while (dr.Read())
                {
                    for (int j = 0; j < dr.FieldCount; j++)
                    {
                        string str = dr.GetValue(j).ToString();
                        str = " " + str;
                        if (str.Length < 12)
                        {
                            str = str.PadRight(12);
                        }
                        else
                        {
                            str = str.Substring(0, 12);
                        }
                        str += "\t|";

                        obuvStr += str;
                    }
                    listBox.Items.Add(obuvStr);
                    obuvStr = "";
                }
            }
        }

        public void PrintAllShoe(DataTable dt, ComboBox comboBox)
        {
            string obuvStr = "";
            using (DataTableReader dr = dt.CreateDataReader())
            {
                while (dr.Read())
                {
                    for (int j = 0; j < dr.FieldCount; j++)
                    {
                        string str = dr.GetValue(j).ToString();
                        str = " " + str;
                        if (str.Length < 12)
                        {
                            str = str.PadRight(12);
                        }
                        else
                        {
                            str = str.Substring(0, 12);
                        }
                        str += "\t|";

                        obuvStr += str;
                    }
                    comboBox.Items.Add(obuvStr);
                    obuvStr = "";
                }
            }
        }

        public bool SearchListBoxForKey(ListBox listBox, string key)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                string index = listBox.Items[i].ToString().Substring(0, 12).Trim();
                if (index == key) return true;
            }
            return false;
        }
    }
}
