using System;
using System.Windows.Forms;

namespace ShoeShopApp
{
    public partial class SoldAmountForm : Form
    {
        public SoldAmountForm()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text == "" || Int32.Parse(amountTextBox.Text) < 0)
            {
                AddChekForm.LastSoldAmount = 1;
            }
            else
            {
                AddChekForm.LastSoldAmount = Int32.Parse(amountTextBox.Text);
            }
            this.Close();
        }
    }
}
