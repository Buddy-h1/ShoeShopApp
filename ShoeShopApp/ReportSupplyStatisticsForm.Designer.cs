
namespace ShoeShopApp
{
    partial class ReportSupplyStatisticsForm
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.finishDateTextBox = new System.Windows.Forms.TextBox();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.finishDateLabel = new System.Windows.Forms.Label();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.shopLabel = new System.Windows.Forms.Label();
            this.shopTextBox = new System.Windows.Forms.TextBox();
            this.organizationLabel = new System.Windows.Forms.Label();
            this.organizationTextBox = new System.Windows.Forms.TextBox();
            this.reportNumberLabel = new System.Windows.Forms.Label();
            this.reportNumberTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(300, 34);
            this.infoLabel.TabIndex = 16;
            this.infoLabel.Text = "Введите границы периода, за который необходимо сформировать статистику.";
            // 
            // startDateLabel
            // 
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateLabel.ForeColor = System.Drawing.Color.Black;
            this.startDateLabel.Location = new System.Drawing.Point(12, 96);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(176, 13);
            this.startDateLabel.TabIndex = 17;
            this.startDateLabel.Text = "Начало периода (ГГГГ-ММ-ДД):";
            // 
            // finishDateTextBox
            // 
            this.finishDateTextBox.Location = new System.Drawing.Point(15, 166);
            this.finishDateTextBox.Name = "finishDateTextBox";
            this.finishDateTextBox.Size = new System.Drawing.Size(163, 20);
            this.finishDateTextBox.TabIndex = 18;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(15, 112);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(163, 20);
            this.startDateTextBox.TabIndex = 17;
            // 
            // finishDateLabel
            // 
            this.finishDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishDateLabel.ForeColor = System.Drawing.Color.Black;
            this.finishDateLabel.Location = new System.Drawing.Point(12, 150);
            this.finishDateLabel.Name = "finishDateLabel";
            this.finishDateLabel.Size = new System.Drawing.Size(176, 13);
            this.finishDateLabel.TabIndex = 20;
            this.finishDateLabel.Text = "Конец периода (ГГГГ-ММ-ДД):";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(15, 246);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(277, 40);
            this.generateReportButton.TabIndex = 21;
            this.generateReportButton.Text = "Сформировать отчёт";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // shopLabel
            // 
            this.shopLabel.AutoSize = true;
            this.shopLabel.Location = new System.Drawing.Point(156, 204);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(54, 13);
            this.shopLabel.TabIndex = 25;
            this.shopLabel.Text = "Магазин:";
            // 
            // shopTextBox
            // 
            this.shopTextBox.Location = new System.Drawing.Point(159, 220);
            this.shopTextBox.Name = "shopTextBox";
            this.shopTextBox.Size = new System.Drawing.Size(133, 20);
            this.shopTextBox.TabIndex = 23;
            // 
            // organizationLabel
            // 
            this.organizationLabel.AutoSize = true;
            this.organizationLabel.Location = new System.Drawing.Point(12, 204);
            this.organizationLabel.Name = "organizationLabel";
            this.organizationLabel.Size = new System.Drawing.Size(77, 13);
            this.organizationLabel.TabIndex = 24;
            this.organizationLabel.Text = "Организация:";
            // 
            // organizationTextBox
            // 
            this.organizationTextBox.Location = new System.Drawing.Point(15, 220);
            this.organizationTextBox.Name = "organizationTextBox";
            this.organizationTextBox.Size = new System.Drawing.Size(133, 20);
            this.organizationTextBox.TabIndex = 22;
            // 
            // reportNumberLabel
            // 
            this.reportNumberLabel.AutoSize = true;
            this.reportNumberLabel.Location = new System.Drawing.Point(12, 43);
            this.reportNumberLabel.Name = "reportNumberLabel";
            this.reportNumberLabel.Size = new System.Drawing.Size(80, 13);
            this.reportNumberLabel.TabIndex = 27;
            this.reportNumberLabel.Text = "Номер отчета:";
            // 
            // reportNumberTextBox
            // 
            this.reportNumberTextBox.Location = new System.Drawing.Point(15, 59);
            this.reportNumberTextBox.Name = "reportNumberTextBox";
            this.reportNumberTextBox.Size = new System.Drawing.Size(163, 20);
            this.reportNumberTextBox.TabIndex = 26;
            // 
            // ReportSupplyStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 301);
            this.Controls.Add(this.reportNumberLabel);
            this.Controls.Add(this.reportNumberTextBox);
            this.Controls.Add(this.shopLabel);
            this.Controls.Add(this.shopTextBox);
            this.Controls.Add(this.organizationLabel);
            this.Controls.Add(this.organizationTextBox);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.finishDateLabel);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.finishDateTextBox);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReportSupplyStatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры отчёта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.TextBox finishDateTextBox;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.Label finishDateLabel;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.TextBox shopTextBox;
        private System.Windows.Forms.Label organizationLabel;
        private System.Windows.Forms.TextBox organizationTextBox;
        private System.Windows.Forms.Label reportNumberLabel;
        private System.Windows.Forms.TextBox reportNumberTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}