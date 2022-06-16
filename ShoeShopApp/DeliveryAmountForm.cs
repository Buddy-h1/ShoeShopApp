using System;
using System.Windows.Forms;

namespace ShoeShopApp
{
    public partial class DeliveryAmountForm : Form
    {
        public DeliveryAmountForm()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text == "" || Int32.Parse(amountTextBox.Text) < 0)
            {
                AddPostavkaForm.LastDeliveryAmount = 0;
            }
            else
            {
                AddPostavkaForm.LastDeliveryAmount = Int32.Parse(amountTextBox.Text);
            }
            this.Close();
        }
    }
}
