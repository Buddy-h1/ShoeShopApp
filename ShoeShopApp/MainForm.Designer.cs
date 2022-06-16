
namespace ShoeShopApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPostavshchikButton = new System.Windows.Forms.Button();
            this.addPostavkaButton = new System.Windows.Forms.Button();
            this.addChekButton = new System.Windows.Forms.Button();
            this.reportSalesButton = new System.Windows.Forms.Button();
            this.reportSupplyStatisticsButton = new System.Windows.Forms.Button();
            this.reportShoeClassificationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPostavshchikButton
            // 
            this.addPostavshchikButton.Location = new System.Drawing.Point(12, 12);
            this.addPostavshchikButton.Name = "addPostavshchikButton";
            this.addPostavshchikButton.Size = new System.Drawing.Size(103, 93);
            this.addPostavshchikButton.TabIndex = 4;
            this.addPostavshchikButton.Text = "Добавить поставщика обуви";
            this.addPostavshchikButton.UseVisualStyleBackColor = true;
            this.addPostavshchikButton.Click += new System.EventHandler(this.addPostavshchikButton_Click);
            // 
            // addPostavkaButton
            // 
            this.addPostavkaButton.Location = new System.Drawing.Point(121, 12);
            this.addPostavkaButton.Name = "addPostavkaButton";
            this.addPostavkaButton.Size = new System.Drawing.Size(103, 93);
            this.addPostavkaButton.TabIndex = 5;
            this.addPostavkaButton.Text = "Добавить поставку";
            this.addPostavkaButton.UseVisualStyleBackColor = true;
            this.addPostavkaButton.Click += new System.EventHandler(this.addPostavkaButton_Click);
            // 
            // addChekButton
            // 
            this.addChekButton.Location = new System.Drawing.Point(230, 12);
            this.addChekButton.Name = "addChekButton";
            this.addChekButton.Size = new System.Drawing.Size(103, 93);
            this.addChekButton.TabIndex = 6;
            this.addChekButton.Text = "Добавить продажу (чек)";
            this.addChekButton.UseVisualStyleBackColor = true;
            this.addChekButton.Click += new System.EventHandler(this.addChekButton_Click);
            // 
            // reportSalesButton
            // 
            this.reportSalesButton.Location = new System.Drawing.Point(12, 111);
            this.reportSalesButton.Name = "reportSalesButton";
            this.reportSalesButton.Size = new System.Drawing.Size(103, 93);
            this.reportSalesButton.TabIndex = 7;
            this.reportSalesButton.Text = "Создать отчёт о реализации продукции";
            this.reportSalesButton.UseVisualStyleBackColor = true;
            this.reportSalesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportSupplyStatisticsButton
            // 
            this.reportSupplyStatisticsButton.Location = new System.Drawing.Point(121, 110);
            this.reportSupplyStatisticsButton.Name = "reportSupplyStatisticsButton";
            this.reportSupplyStatisticsButton.Size = new System.Drawing.Size(103, 93);
            this.reportSupplyStatisticsButton.TabIndex = 1;
            this.reportSupplyStatisticsButton.Text = "Создать отчёт о статистике поставок от всех поставщиков";
            this.reportSupplyStatisticsButton.UseVisualStyleBackColor = true;
            this.reportSupplyStatisticsButton.Click += new System.EventHandler(this.reportSupplyStatisticsButton_Click);
            // 
            // reportShoeClassificationButton
            // 
            this.reportShoeClassificationButton.Location = new System.Drawing.Point(230, 110);
            this.reportShoeClassificationButton.Name = "reportShoeClassificationButton";
            this.reportShoeClassificationButton.Size = new System.Drawing.Size(103, 93);
            this.reportShoeClassificationButton.TabIndex = 9;
            this.reportShoeClassificationButton.Text = "Создать отчёт о классификации обуви (в наличии)";
            this.reportShoeClassificationButton.UseVisualStyleBackColor = true;
            this.reportShoeClassificationButton.Click += new System.EventHandler(this.reportShoeClassificationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 215);
            this.Controls.Add(this.reportShoeClassificationButton);
            this.Controls.Add(this.reportSupplyStatisticsButton);
            this.Controls.Add(this.reportSalesButton);
            this.Controls.Add(this.addChekButton);
            this.Controls.Add(this.addPostavkaButton);
            this.Controls.Add(this.addPostavshchikButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoeShopApp";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addPostavshchikButton;
        private System.Windows.Forms.Button addPostavkaButton;
        private System.Windows.Forms.Button addChekButton;
        private System.Windows.Forms.Button reportSalesButton;
        private System.Windows.Forms.Button reportSupplyStatisticsButton;
        private System.Windows.Forms.Button reportShoeClassificationButton;
    }
}

