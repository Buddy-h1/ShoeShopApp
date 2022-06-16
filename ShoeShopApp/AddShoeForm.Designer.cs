
namespace ShoeShopApp
{
    partial class AddShoeForm
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
            this.naimenovanieLabel = new System.Windows.Forms.Label();
            this.naimenovanieTextBox = new System.Windows.Forms.TextBox();
            this.polTextBox = new System.Windows.Forms.TextBox();
            this.polLabel = new System.Windows.Forms.Label();
            this.kategoriyaTextBox = new System.Windows.Forms.TextBox();
            this.kategoriyaLabel = new System.Windows.Forms.Label();
            this.razmerTextBox = new System.Windows.Forms.TextBox();
            this.razmerLabel = new System.Windows.Forms.Label();
            this.cenaProdazhiTextBox = new System.Windows.Forms.TextBox();
            this.cenaProdazhiLabel = new System.Windows.Forms.Label();
            this.kolichestvoTextBox = new System.Windows.Forms.TextBox();
            this.kolichestvoLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naimenovanieLabel
            // 
            this.naimenovanieLabel.AutoSize = true;
            this.naimenovanieLabel.Location = new System.Drawing.Point(15, 16);
            this.naimenovanieLabel.Name = "naimenovanieLabel";
            this.naimenovanieLabel.Size = new System.Drawing.Size(83, 13);
            this.naimenovanieLabel.TabIndex = 0;
            this.naimenovanieLabel.Text = "Наименование";
            // 
            // naimenovanieTextBox
            // 
            this.naimenovanieTextBox.Location = new System.Drawing.Point(18, 32);
            this.naimenovanieTextBox.Name = "naimenovanieTextBox";
            this.naimenovanieTextBox.Size = new System.Drawing.Size(215, 20);
            this.naimenovanieTextBox.TabIndex = 1;
            // 
            // polTextBox
            // 
            this.polTextBox.Location = new System.Drawing.Point(18, 86);
            this.polTextBox.Name = "polTextBox";
            this.polTextBox.Size = new System.Drawing.Size(215, 20);
            this.polTextBox.TabIndex = 2;
            // 
            // polLabel
            // 
            this.polLabel.AutoSize = true;
            this.polLabel.Location = new System.Drawing.Point(15, 70);
            this.polLabel.Name = "polLabel";
            this.polLabel.Size = new System.Drawing.Size(27, 13);
            this.polLabel.TabIndex = 2;
            this.polLabel.Text = "Пол";
            // 
            // kategoriyaTextBox
            // 
            this.kategoriyaTextBox.Location = new System.Drawing.Point(18, 140);
            this.kategoriyaTextBox.Name = "kategoriyaTextBox";
            this.kategoriyaTextBox.Size = new System.Drawing.Size(215, 20);
            this.kategoriyaTextBox.TabIndex = 3;
            // 
            // kategoriyaLabel
            // 
            this.kategoriyaLabel.AutoSize = true;
            this.kategoriyaLabel.Location = new System.Drawing.Point(15, 124);
            this.kategoriyaLabel.Name = "kategoriyaLabel";
            this.kategoriyaLabel.Size = new System.Drawing.Size(60, 13);
            this.kategoriyaLabel.TabIndex = 4;
            this.kategoriyaLabel.Text = "Категория";
            // 
            // razmerTextBox
            // 
            this.razmerTextBox.Location = new System.Drawing.Point(258, 32);
            this.razmerTextBox.Name = "razmerTextBox";
            this.razmerTextBox.Size = new System.Drawing.Size(215, 20);
            this.razmerTextBox.TabIndex = 4;
            // 
            // razmerLabel
            // 
            this.razmerLabel.AutoSize = true;
            this.razmerLabel.Location = new System.Drawing.Point(255, 16);
            this.razmerLabel.Name = "razmerLabel";
            this.razmerLabel.Size = new System.Drawing.Size(46, 13);
            this.razmerLabel.TabIndex = 6;
            this.razmerLabel.Text = "Размер";
            // 
            // cenaProdazhiTextBox
            // 
            this.cenaProdazhiTextBox.Location = new System.Drawing.Point(258, 140);
            this.cenaProdazhiTextBox.Name = "cenaProdazhiTextBox";
            this.cenaProdazhiTextBox.Size = new System.Drawing.Size(215, 20);
            this.cenaProdazhiTextBox.TabIndex = 6;
            // 
            // cenaProdazhiLabel
            // 
            this.cenaProdazhiLabel.AutoSize = true;
            this.cenaProdazhiLabel.Location = new System.Drawing.Point(255, 124);
            this.cenaProdazhiLabel.Name = "cenaProdazhiLabel";
            this.cenaProdazhiLabel.Size = new System.Drawing.Size(80, 13);
            this.cenaProdazhiLabel.TabIndex = 8;
            this.cenaProdazhiLabel.Text = "Цена продажи";
            // 
            // kolichestvoTextBox
            // 
            this.kolichestvoTextBox.Location = new System.Drawing.Point(258, 86);
            this.kolichestvoTextBox.Name = "kolichestvoTextBox";
            this.kolichestvoTextBox.Size = new System.Drawing.Size(215, 20);
            this.kolichestvoTextBox.TabIndex = 5;
            // 
            // kolichestvoLabel
            // 
            this.kolichestvoLabel.AutoSize = true;
            this.kolichestvoLabel.Location = new System.Drawing.Point(255, 70);
            this.kolichestvoLabel.Name = "kolichestvoLabel";
            this.kolichestvoLabel.Size = new System.Drawing.Size(218, 13);
            this.kolichestvoLabel.TabIndex = 10;
            this.kolichestvoLabel.Text = "Количество (в данный момент на складе)";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(18, 176);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(457, 44);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddShoeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 234);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.kolichestvoTextBox);
            this.Controls.Add(this.kolichestvoLabel);
            this.Controls.Add(this.cenaProdazhiTextBox);
            this.Controls.Add(this.cenaProdazhiLabel);
            this.Controls.Add(this.razmerTextBox);
            this.Controls.Add(this.razmerLabel);
            this.Controls.Add(this.kategoriyaTextBox);
            this.Controls.Add(this.kategoriyaLabel);
            this.Controls.Add(this.polTextBox);
            this.Controls.Add(this.polLabel);
            this.Controls.Add(this.naimenovanieTextBox);
            this.Controls.Add(this.naimenovanieLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddShoeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление обуви в базу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naimenovanieLabel;
        private System.Windows.Forms.TextBox naimenovanieTextBox;
        private System.Windows.Forms.TextBox polTextBox;
        private System.Windows.Forms.Label polLabel;
        private System.Windows.Forms.TextBox kategoriyaTextBox;
        private System.Windows.Forms.Label kategoriyaLabel;
        private System.Windows.Forms.TextBox razmerTextBox;
        private System.Windows.Forms.Label razmerLabel;
        private System.Windows.Forms.TextBox cenaProdazhiTextBox;
        private System.Windows.Forms.Label cenaProdazhiLabel;
        private System.Windows.Forms.TextBox kolichestvoTextBox;
        private System.Windows.Forms.Label kolichestvoLabel;
        private System.Windows.Forms.Button addButton;
    }
}