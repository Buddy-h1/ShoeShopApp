
namespace ShoeShopApp
{
    partial class AddChekForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.selectedShoeListBox = new System.Windows.Forms.ListBox();
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.allShoeListBox = new System.Windows.Forms.ListBox();
            this.stoimostTextBox = new System.Windows.Forms.TextBox();
            this.stoimostLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.addChekbutton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(540, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "id             Наименование       Пол                         Категория          " +
    "    Размер   Кол-во    Цена                    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "id             Наименование       Пол                         Категория          " +
    "    Размер   Кол-во    Цена                    ";
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel2.Location = new System.Drawing.Point(537, 9);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(138, 16);
            this.InfoLabel2.TabIndex = 12;
            this.InfoLabel2.Text = "Обувь для продажи:";
            // 
            // selectedShoeListBox
            // 
            this.selectedShoeListBox.FormattingEnabled = true;
            this.selectedShoeListBox.Location = new System.Drawing.Point(540, 47);
            this.selectedShoeListBox.Name = "selectedShoeListBox";
            this.selectedShoeListBox.Size = new System.Drawing.Size(521, 381);
            this.selectedShoeListBox.TabIndex = 11;
            this.selectedShoeListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.selectedShoeListBox_MouseDoubleClick);
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel1.Location = new System.Drawing.Point(9, 9);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(342, 16);
            this.InfoLabel1.TabIndex = 10;
            this.InfoLabel1.Text = "Выберите из списка обувь, которая будет продана";
            // 
            // allShoeListBox
            // 
            this.allShoeListBox.FormattingEnabled = true;
            this.allShoeListBox.Location = new System.Drawing.Point(12, 47);
            this.allShoeListBox.Name = "allShoeListBox";
            this.allShoeListBox.Size = new System.Drawing.Size(521, 511);
            this.allShoeListBox.TabIndex = 9;
            this.allShoeListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.allShoeListBox_MouseDoubleClick);
            // 
            // stoimostTextBox
            // 
            this.stoimostTextBox.Location = new System.Drawing.Point(540, 502);
            this.stoimostTextBox.Name = "stoimostTextBox";
            this.stoimostTextBox.Size = new System.Drawing.Size(521, 20);
            this.stoimostTextBox.TabIndex = 20;
            // 
            // stoimostLabel
            // 
            this.stoimostLabel.AutoSize = true;
            this.stoimostLabel.Location = new System.Drawing.Point(537, 486);
            this.stoimostLabel.Name = "stoimostLabel";
            this.stoimostLabel.Size = new System.Drawing.Size(191, 13);
            this.stoimostLabel.TabIndex = 19;
            this.stoimostLabel.Text = "Общая стоимость (с учётом скидки)";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(540, 452);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(521, 20);
            this.dateTextBox.TabIndex = 18;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(537, 436);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(108, 13);
            this.dateLabel.TabIndex = 17;
            this.dateLabel.Text = "Дата (ГГГГ-ММ-ДД)";
            // 
            // addChekbutton
            // 
            this.addChekbutton.Location = new System.Drawing.Point(540, 535);
            this.addChekbutton.Name = "addChekbutton";
            this.addChekbutton.Size = new System.Drawing.Size(521, 23);
            this.addChekbutton.TabIndex = 16;
            this.addChekbutton.Text = "Добавить продажу (чек)";
            this.addChekbutton.UseVisualStyleBackColor = true;
            this.addChekbutton.Click += new System.EventHandler(this.addChekbutton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(420, 6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(113, 23);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Обновить список";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // AddChekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 568);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.stoimostTextBox);
            this.Controls.Add(this.stoimostLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.addChekbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.selectedShoeListBox);
            this.Controls.Add(this.InfoLabel1);
            this.Controls.Add(this.allShoeListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddChekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление продажи (чека)";
            this.Shown += new System.EventHandler(this.AddChekForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfoLabel2;
        private System.Windows.Forms.ListBox selectedShoeListBox;
        private System.Windows.Forms.Label InfoLabel1;
        private System.Windows.Forms.ListBox allShoeListBox;
        private System.Windows.Forms.TextBox stoimostTextBox;
        private System.Windows.Forms.Label stoimostLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button addChekbutton;
        private System.Windows.Forms.Button updateButton;
    }
}