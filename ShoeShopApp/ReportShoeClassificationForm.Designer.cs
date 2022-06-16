
namespace ShoeShopApp
{
    partial class ReportShoeClassificationForm
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
            this.reportNumberLabel = new System.Windows.Forms.Label();
            this.reportNumberTextBox = new System.Windows.Forms.TextBox();
            this.shopLabel = new System.Windows.Forms.Label();
            this.shopTextBox = new System.Windows.Forms.TextBox();
            this.organizationLabel = new System.Windows.Forms.Label();
            this.organizationTextBox = new System.Windows.Forms.TextBox();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // reportNumberLabel
            // 
            this.reportNumberLabel.AutoSize = true;
            this.reportNumberLabel.Location = new System.Drawing.Point(9, 14);
            this.reportNumberLabel.Name = "reportNumberLabel";
            this.reportNumberLabel.Size = new System.Drawing.Size(80, 13);
            this.reportNumberLabel.TabIndex = 29;
            this.reportNumberLabel.Text = "Номер отчета:";
            // 
            // reportNumberTextBox
            // 
            this.reportNumberTextBox.Location = new System.Drawing.Point(12, 30);
            this.reportNumberTextBox.Name = "reportNumberTextBox";
            this.reportNumberTextBox.Size = new System.Drawing.Size(228, 20);
            this.reportNumberTextBox.TabIndex = 28;
            // 
            // shopLabel
            // 
            this.shopLabel.AutoSize = true;
            this.shopLabel.Location = new System.Drawing.Point(10, 116);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(54, 13);
            this.shopLabel.TabIndex = 33;
            this.shopLabel.Text = "Магазин:";
            // 
            // shopTextBox
            // 
            this.shopTextBox.Location = new System.Drawing.Point(13, 132);
            this.shopTextBox.Name = "shopTextBox";
            this.shopTextBox.Size = new System.Drawing.Size(227, 20);
            this.shopTextBox.TabIndex = 31;
            // 
            // organizationLabel
            // 
            this.organizationLabel.AutoSize = true;
            this.organizationLabel.Location = new System.Drawing.Point(9, 63);
            this.organizationLabel.Name = "organizationLabel";
            this.organizationLabel.Size = new System.Drawing.Size(77, 13);
            this.organizationLabel.TabIndex = 32;
            this.organizationLabel.Text = "Организация:";
            // 
            // organizationTextBox
            // 
            this.organizationTextBox.Location = new System.Drawing.Point(12, 79);
            this.organizationTextBox.Name = "organizationTextBox";
            this.organizationTextBox.Size = new System.Drawing.Size(228, 20);
            this.organizationTextBox.TabIndex = 30;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(13, 168);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(227, 40);
            this.generateReportButton.TabIndex = 1;
            this.generateReportButton.Text = "Сформировать отчёт";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // ReportShoeClassificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 219);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.shopLabel);
            this.Controls.Add(this.shopTextBox);
            this.Controls.Add(this.organizationLabel);
            this.Controls.Add(this.organizationTextBox);
            this.Controls.Add(this.reportNumberLabel);
            this.Controls.Add(this.reportNumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReportShoeClassificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры отчёта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportNumberLabel;
        private System.Windows.Forms.TextBox reportNumberTextBox;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.TextBox shopTextBox;
        private System.Windows.Forms.Label organizationLabel;
        private System.Windows.Forms.TextBox organizationTextBox;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}