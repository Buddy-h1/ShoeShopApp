
namespace ShoeShopApp
{
    partial class DeliveryAmountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfoLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(9, 10);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(201, 13);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Введите количество выбранной обуви";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(12, 26);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(198, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(12, 52);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(75, 23);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "Ввести";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // DeliveryAmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 87);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DeliveryAmountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Кол-во обуви";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button inputButton;
    }
}