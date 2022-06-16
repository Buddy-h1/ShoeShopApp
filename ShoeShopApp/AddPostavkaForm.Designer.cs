
namespace ShoeShopApp
{
    partial class AddPostavkaForm
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
            this.allShoeListBox = new System.Windows.Forms.ListBox();
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.addShoebutton = new System.Windows.Forms.Button();
            this.selectedShoeListBox = new System.Windows.Forms.ListBox();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPostavkabutton = new System.Windows.Forms.Button();
            this.postavshchikLabel = new System.Windows.Forms.Label();
            this.postavshchikComboBox = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.stoimostTextBox = new System.Windows.Forms.TextBox();
            this.stoimostLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allShoeListBox
            // 
            this.allShoeListBox.FormattingEnabled = true;
            this.allShoeListBox.Location = new System.Drawing.Point(12, 51);
            this.allShoeListBox.Name = "allShoeListBox";
            this.allShoeListBox.Size = new System.Drawing.Size(521, 511);
            this.allShoeListBox.TabIndex = 0;
            this.allShoeListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.allShoeListBox_MouseDoubleClick);
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel1.Location = new System.Drawing.Point(9, 13);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(386, 16);
            this.InfoLabel1.TabIndex = 1;
            this.InfoLabel1.Text = "Выберите из списка обувь, которая находится в поставке";
            // 
            // addShoebutton
            // 
            this.addShoebutton.Location = new System.Drawing.Point(12, 568);
            this.addShoebutton.Name = "addShoebutton";
            this.addShoebutton.Size = new System.Drawing.Size(522, 23);
            this.addShoebutton.TabIndex = 2;
            this.addShoebutton.Text = "Добавить новую обувь";
            this.addShoebutton.UseVisualStyleBackColor = true;
            this.addShoebutton.Click += new System.EventHandler(this.addShoebutton_Click);
            // 
            // selectedShoeListBox
            // 
            this.selectedShoeListBox.FormattingEnabled = true;
            this.selectedShoeListBox.Location = new System.Drawing.Point(540, 51);
            this.selectedShoeListBox.Name = "selectedShoeListBox";
            this.selectedShoeListBox.Size = new System.Drawing.Size(521, 355);
            this.selectedShoeListBox.TabIndex = 3;
            this.selectedShoeListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.selectedShoeListBox_MouseDoubleClick);
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel2.Location = new System.Drawing.Point(537, 13);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(127, 16);
            this.InfoLabel2.TabIndex = 4;
            this.InfoLabel2.Text = "Обувь в поставке:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "id             Наименование       Пол                         Категория          " +
    "    Размер   Кол-во    Цена                    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(540, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "id             Наименование       Пол                         Категория          " +
    "    Размер   Кол-во    Цена                    ";
            // 
            // addPostavkabutton
            // 
            this.addPostavkabutton.Location = new System.Drawing.Point(540, 568);
            this.addPostavkabutton.Name = "addPostavkabutton";
            this.addPostavkabutton.Size = new System.Drawing.Size(521, 23);
            this.addPostavkabutton.TabIndex = 9;
            this.addPostavkabutton.Text = "Добавить поставку";
            this.addPostavkabutton.UseVisualStyleBackColor = true;
            this.addPostavkabutton.Click += new System.EventHandler(this.addPostavkabutton_Click);
            // 
            // postavshchikLabel
            // 
            this.postavshchikLabel.AutoSize = true;
            this.postavshchikLabel.Location = new System.Drawing.Point(537, 418);
            this.postavshchikLabel.Name = "postavshchikLabel";
            this.postavshchikLabel.Size = new System.Drawing.Size(122, 13);
            this.postavshchikLabel.TabIndex = 10;
            this.postavshchikLabel.Text = "Выберите поставщика";
            // 
            // postavshchikComboBox
            // 
            this.postavshchikComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postavshchikComboBox.FormattingEnabled = true;
            this.postavshchikComboBox.Location = new System.Drawing.Point(540, 434);
            this.postavshchikComboBox.Name = "postavshchikComboBox";
            this.postavshchikComboBox.Size = new System.Drawing.Size(521, 21);
            this.postavshchikComboBox.TabIndex = 11;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(537, 468);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(108, 13);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Дата (ГГГГ-ММ-ДД)";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(540, 484);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(521, 20);
            this.dateTextBox.TabIndex = 13;
            // 
            // stoimostTextBox
            // 
            this.stoimostTextBox.Location = new System.Drawing.Point(540, 534);
            this.stoimostTextBox.Name = "stoimostTextBox";
            this.stoimostTextBox.Size = new System.Drawing.Size(521, 20);
            this.stoimostTextBox.TabIndex = 15;
            // 
            // stoimostLabel
            // 
            this.stoimostLabel.AutoSize = true;
            this.stoimostLabel.Location = new System.Drawing.Point(537, 518);
            this.stoimostLabel.Name = "stoimostLabel";
            this.stoimostLabel.Size = new System.Drawing.Size(99, 13);
            this.stoimostLabel.TabIndex = 14;
            this.stoimostLabel.Text = "Общая стоимость";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(421, 10);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(113, 23);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Обновить список";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // AddPostavkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 598);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.stoimostTextBox);
            this.Controls.Add(this.stoimostLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.postavshchikComboBox);
            this.Controls.Add(this.postavshchikLabel);
            this.Controls.Add(this.addPostavkabutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.selectedShoeListBox);
            this.Controls.Add(this.addShoebutton);
            this.Controls.Add(this.InfoLabel1);
            this.Controls.Add(this.allShoeListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddPostavkaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление новой поставки обуви";
            this.Shown += new System.EventHandler(this.AddPostavkaForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allShoeListBox;
        private System.Windows.Forms.Label InfoLabel1;
        private System.Windows.Forms.Button addShoebutton;
        private System.Windows.Forms.ListBox selectedShoeListBox;
        private System.Windows.Forms.Label InfoLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPostavkabutton;
        private System.Windows.Forms.Label postavshchikLabel;
        private System.Windows.Forms.ComboBox postavshchikComboBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox stoimostTextBox;
        private System.Windows.Forms.Label stoimostLabel;
        private System.Windows.Forms.Button updateButton;
    }
}