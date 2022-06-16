
namespace ShoeShopApp
{
    partial class AddPostavshchikForm
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
            this.nazvanieTextBox = new System.Windows.Forms.TextBox();
            this.nazvanieLabel = new System.Windows.Forms.Label();
            this.adresLabel = new System.Windows.Forms.Label();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.rukovodstvoLabel = new System.Windows.Forms.Label();
            this.rukovodstvoTextBox = new System.Windows.Forms.TextBox();
            this.nomerTelefonaLabel = new System.Windows.Forms.Label();
            this.nomerTelefonaTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazvanieTextBox
            // 
            this.nazvanieTextBox.Location = new System.Drawing.Point(12, 29);
            this.nazvanieTextBox.Name = "nazvanieTextBox";
            this.nazvanieTextBox.Size = new System.Drawing.Size(181, 20);
            this.nazvanieTextBox.TabIndex = 0;
            // 
            // nazvanieLabel
            // 
            this.nazvanieLabel.AutoSize = true;
            this.nazvanieLabel.Location = new System.Drawing.Point(12, 10);
            this.nazvanieLabel.Name = "nazvanieLabel";
            this.nazvanieLabel.Size = new System.Drawing.Size(181, 13);
            this.nazvanieLabel.TabIndex = 1;
            this.nazvanieLabel.Text = "Название компании (поставщика)";
            // 
            // adresLabel
            // 
            this.adresLabel.AutoSize = true;
            this.adresLabel.Location = new System.Drawing.Point(220, 10);
            this.adresLabel.Name = "adresLabel";
            this.adresLabel.Size = new System.Drawing.Size(162, 13);
            this.adresLabel.TabIndex = 3;
            this.adresLabel.Text = "Адрес компании (поставщика)";
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(220, 29);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(181, 20);
            this.adresTextBox.TabIndex = 2;
            // 
            // rukovodstvoLabel
            // 
            this.rukovodstvoLabel.AutoSize = true;
            this.rukovodstvoLabel.Location = new System.Drawing.Point(12, 68);
            this.rukovodstvoLabel.Name = "rukovodstvoLabel";
            this.rukovodstvoLabel.Size = new System.Drawing.Size(108, 13);
            this.rukovodstvoLabel.TabIndex = 5;
            this.rukovodstvoLabel.Text = "Руководство (ФИО)";
            // 
            // rukovodstvoTextBox
            // 
            this.rukovodstvoTextBox.Location = new System.Drawing.Point(12, 84);
            this.rukovodstvoTextBox.Name = "rukovodstvoTextBox";
            this.rukovodstvoTextBox.Size = new System.Drawing.Size(181, 20);
            this.rukovodstvoTextBox.TabIndex = 4;
            // 
            // nomerTelefonaLabel
            // 
            this.nomerTelefonaLabel.AutoSize = true;
            this.nomerTelefonaLabel.Location = new System.Drawing.Point(220, 65);
            this.nomerTelefonaLabel.Name = "nomerTelefonaLabel";
            this.nomerTelefonaLabel.Size = new System.Drawing.Size(93, 13);
            this.nomerTelefonaLabel.TabIndex = 7;
            this.nomerTelefonaLabel.Text = "Номер телефона";
            // 
            // nomerTelefonaTextBox
            // 
            this.nomerTelefonaTextBox.Location = new System.Drawing.Point(220, 84);
            this.nomerTelefonaTextBox.Name = "nomerTelefonaTextBox";
            this.nomerTelefonaTextBox.Size = new System.Drawing.Size(181, 20);
            this.nomerTelefonaTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 120);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(389, 33);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddPostavshchikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 164);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nomerTelefonaLabel);
            this.Controls.Add(this.nomerTelefonaTextBox);
            this.Controls.Add(this.rukovodstvoLabel);
            this.Controls.Add(this.rukovodstvoTextBox);
            this.Controls.Add(this.adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.nazvanieLabel);
            this.Controls.Add(this.nazvanieTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddPostavshchikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление поставщика в базу данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nazvanieTextBox;
        private System.Windows.Forms.Label nazvanieLabel;
        private System.Windows.Forms.Label adresLabel;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.Label rukovodstvoLabel;
        private System.Windows.Forms.TextBox rukovodstvoTextBox;
        private System.Windows.Forms.Label nomerTelefonaLabel;
        private System.Windows.Forms.TextBox nomerTelefonaTextBox;
        private System.Windows.Forms.Button addButton;
    }
}