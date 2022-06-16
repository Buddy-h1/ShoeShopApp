
namespace ShoeShopApp
{
    partial class ReportSalesForm
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
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.dataLabel = new System.Windows.Forms.Label();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.reportNumberLabel = new System.Windows.Forms.Label();
            this.reportNumberTextBox = new System.Windows.Forms.TextBox();
            this.organizationLabel = new System.Windows.Forms.Label();
            this.organizationTextBox = new System.Windows.Forms.TextBox();
            this.shopLabel = new System.Windows.Forms.Label();
            this.shopTextBox = new System.Windows.Forms.TextBox();
            this.transmitterLabel = new System.Windows.Forms.Label();
            this.transmitterTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(186, 94);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(137, 20);
            this.dataTextBox.TabIndex = 2;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(183, 78);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(111, 13);
            this.dataLabel.TabIndex = 1;
            this.dataLabel.Text = "Дата (ГГГГ-ММ-ДД):";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(21, 242);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(302, 40);
            this.generateReportButton.TabIndex = 0;
            this.generateReportButton.Text = "Сформировать отчёт";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportNumberLabel
            // 
            this.reportNumberLabel.AutoSize = true;
            this.reportNumberLabel.Location = new System.Drawing.Point(18, 78);
            this.reportNumberLabel.Name = "reportNumberLabel";
            this.reportNumberLabel.Size = new System.Drawing.Size(80, 13);
            this.reportNumberLabel.TabIndex = 8;
            this.reportNumberLabel.Text = "Номер отчета:";
            // 
            // reportNumberTextBox
            // 
            this.reportNumberTextBox.Location = new System.Drawing.Point(21, 94);
            this.reportNumberTextBox.Name = "reportNumberTextBox";
            this.reportNumberTextBox.Size = new System.Drawing.Size(137, 20);
            this.reportNumberTextBox.TabIndex = 1;
            // 
            // organizationLabel
            // 
            this.organizationLabel.AutoSize = true;
            this.organizationLabel.Location = new System.Drawing.Point(18, 131);
            this.organizationLabel.Name = "organizationLabel";
            this.organizationLabel.Size = new System.Drawing.Size(77, 13);
            this.organizationLabel.TabIndex = 10;
            this.organizationLabel.Text = "Организация:";
            // 
            // organizationTextBox
            // 
            this.organizationTextBox.Location = new System.Drawing.Point(21, 147);
            this.organizationTextBox.Name = "organizationTextBox";
            this.organizationTextBox.Size = new System.Drawing.Size(137, 20);
            this.organizationTextBox.TabIndex = 5;
            // 
            // shopLabel
            // 
            this.shopLabel.AutoSize = true;
            this.shopLabel.Location = new System.Drawing.Point(183, 131);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(54, 13);
            this.shopLabel.TabIndex = 12;
            this.shopLabel.Text = "Магазин:";
            // 
            // shopTextBox
            // 
            this.shopTextBox.Location = new System.Drawing.Point(186, 147);
            this.shopTextBox.Name = "shopTextBox";
            this.shopTextBox.Size = new System.Drawing.Size(137, 20);
            this.shopTextBox.TabIndex = 6;
            // 
            // transmitterLabel
            // 
            this.transmitterLabel.AutoSize = true;
            this.transmitterLabel.Location = new System.Drawing.Point(18, 188);
            this.transmitterLabel.Name = "transmitterLabel";
            this.transmitterLabel.Size = new System.Drawing.Size(76, 13);
            this.transmitterLabel.TabIndex = 14;
            this.transmitterLabel.Text = "Отправитель:";
            // 
            // transmitterTextBox
            // 
            this.transmitterTextBox.Location = new System.Drawing.Point(21, 204);
            this.transmitterTextBox.Name = "transmitterTextBox";
            this.transmitterTextBox.Size = new System.Drawing.Size(302, 20);
            this.transmitterTextBox.TabIndex = 7;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(18, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(305, 69);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "Необходимо указать дату, в которой учитываются последние продажи и поставки (т.е." +
    " нужно указать дату последней продажи или дату последней поставки, а также можно" +
    " более позднюю дату).";
            // 
            // ReportSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 302);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.transmitterLabel);
            this.Controls.Add(this.transmitterTextBox);
            this.Controls.Add(this.shopLabel);
            this.Controls.Add(this.shopTextBox);
            this.Controls.Add(this.organizationLabel);
            this.Controls.Add(this.organizationTextBox);
            this.Controls.Add(this.reportNumberLabel);
            this.Controls.Add(this.reportNumberTextBox);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.dataTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReportSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры отчёта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label reportNumberLabel;
        private System.Windows.Forms.TextBox reportNumberTextBox;
        private System.Windows.Forms.Label organizationLabel;
        private System.Windows.Forms.TextBox organizationTextBox;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.TextBox shopTextBox;
        private System.Windows.Forms.Label transmitterLabel;
        private System.Windows.Forms.TextBox transmitterTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label infoLabel;
    }
}