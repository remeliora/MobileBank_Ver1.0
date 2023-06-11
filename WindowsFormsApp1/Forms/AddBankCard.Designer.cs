namespace WindowsFormsApp1.Forms
{
    partial class AddBankCard
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.PaymentSystemComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.numericUpDownPin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPin)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(304, 11);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 26);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тип карты:";
            // 
            // CardTypeComboBox
            // 
            this.CardTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.CardTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardTypeComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.CardTypeComboBox.FormattingEnabled = true;
            this.CardTypeComboBox.Items.AddRange(new object[] {
            "Дебетовая",
            "Кредитная"});
            this.CardTypeComboBox.Location = new System.Drawing.Point(12, 78);
            this.CardTypeComboBox.Name = "CardTypeComboBox";
            this.CardTypeComboBox.Size = new System.Drawing.Size(317, 32);
            this.CardTypeComboBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Валюта:";
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.CurrencyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrencyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrencyComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "EUR"});
            this.CurrencyComboBox.Location = new System.Drawing.Point(12, 151);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(317, 32);
            this.CurrencyComboBox.TabIndex = 14;
            // 
            // PaymentSystemComboBox
            // 
            this.PaymentSystemComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PaymentSystemComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentSystemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentSystemComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PaymentSystemComboBox.FormattingEnabled = true;
            this.PaymentSystemComboBox.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "Мир"});
            this.PaymentSystemComboBox.Location = new System.Drawing.Point(12, 224);
            this.PaymentSystemComboBox.Name = "PaymentSystemComboBox";
            this.PaymentSystemComboBox.Size = new System.Drawing.Size(317, 32);
            this.PaymentSystemComboBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(11, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Платёжная система:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(11, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "PIN-код:";
            // 
            // AddCardButton
            // 
            this.AddCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.AddCardButton.FlatAppearance.BorderSize = 0;
            this.AddCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCardButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddCardButton.Location = new System.Drawing.Point(11, 358);
            this.AddCardButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(318, 54);
            this.AddCardButton.TabIndex = 25;
            this.AddCardButton.Text = "Создать";
            this.AddCardButton.UseVisualStyleBackColor = false;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // numericUpDownPin
            // 
            this.numericUpDownPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.numericUpDownPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPin.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownPin.Location = new System.Drawing.Point(14, 298);
            this.numericUpDownPin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownPin.Name = "numericUpDownPin";
            this.numericUpDownPin.Size = new System.Drawing.Size(315, 29);
            this.numericUpDownPin.TabIndex = 26;
            // 
            // AddBankCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(341, 425);
            this.Controls.Add(this.numericUpDownPin);
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PaymentSystemComboBox);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBankCard";
            this.Text = "AddBankCard";
            this.Load += new System.EventHandler(this.AddBankCard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddBankCard_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CardTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.ComboBox PaymentSystemComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddCardButton;
        private System.Windows.Forms.NumericUpDown numericUpDownPin;
    }
}