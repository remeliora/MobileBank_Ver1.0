namespace WindowsFormsApp1.Forms
{
    partial class CommunalPaymentsForm
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxCVV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxCardTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxSum = new System.Windows.Forms.TextBox();
            this.CommunalComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PersonalAccountTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(559, 11);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_house_1172545;
            this.pictureBox5.InitialImage = global::WindowsFormsApp1.Properties.Resources.free_icon_house_1172545;
            this.pictureBox5.Location = new System.Drawing.Point(28, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(96, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 29);
            this.label9.TabIndex = 40;
            this.label9.Text = "Коммунальные платежи";
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(173)))), ((int)(((byte)(37)))));
            this.PayButton.FlatAppearance.BorderSize = 0;
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PayButton.Location = new System.Drawing.Point(28, 630);
            this.PayButton.Margin = new System.Windows.Forms.Padding(2);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(547, 62);
            this.PayButton.TabIndex = 45;
            this.PayButton.Text = "Оплатить";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "С карты";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.TextBoxCVV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBoxCardTo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBoxCard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 233);
            this.panel1.TabIndex = 43;
            // 
            // TextBoxCVV
            // 
            this.TextBoxCVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TextBoxCVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCVV.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxCVV.Location = new System.Drawing.Point(271, 172);
            this.TextBoxCVV.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCVV.Multiline = true;
            this.TextBoxCVV.Name = "TextBoxCVV";
            this.TextBoxCVV.Size = new System.Drawing.Size(141, 30);
            this.TextBoxCVV.TabIndex = 13;
            this.TextBoxCVV.Text = "***";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(267, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "CVV-код";
            // 
            // TextBoxCardTo
            // 
            this.TextBoxCardTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TextBoxCardTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCardTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCardTo.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxCardTo.Location = new System.Drawing.Point(22, 172);
            this.TextBoxCardTo.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCardTo.Multiline = true;
            this.TextBoxCardTo.Name = "TextBoxCardTo";
            this.TextBoxCardTo.Size = new System.Drawing.Size(141, 30);
            this.TextBoxCardTo.TabIndex = 11;
            this.TextBoxCardTo.Text = "0/00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Срок действия";
            // 
            // TextBoxCard
            // 
            this.TextBoxCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TextBoxCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxCard.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxCard.Location = new System.Drawing.Point(22, 56);
            this.TextBoxCard.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCard.Multiline = true;
            this.TextBoxCard.Name = "TextBoxCard";
            this.TextBoxCard.Size = new System.Drawing.Size(499, 30);
            this.TextBoxCard.TabIndex = 9;
            this.TextBoxCard.Text = "0000 0000 0000 0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер карты";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label10.Location = new System.Drawing.Point(435, 286);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 29);
            this.label10.TabIndex = 49;
            this.label10.Text = "RUB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label5.Location = new System.Drawing.Point(98, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Сумма";
            // 
            // TextBoxSum
            // 
            this.TextBoxSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TextBoxSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSum.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxSum.Location = new System.Drawing.Point(101, 285);
            this.TextBoxSum.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSum.Multiline = true;
            this.TextBoxSum.Name = "TextBoxSum";
            this.TextBoxSum.Size = new System.Drawing.Size(330, 30);
            this.TextBoxSum.TabIndex = 47;
            // 
            // CommunalComboBox
            // 
            this.CommunalComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.CommunalComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommunalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommunalComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.CommunalComboBox.FormattingEnabled = true;
            this.CommunalComboBox.Location = new System.Drawing.Point(101, 125);
            this.CommunalComboBox.Name = "CommunalComboBox";
            this.CommunalComboBox.Size = new System.Drawing.Size(330, 32);
            this.CommunalComboBox.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(98, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Услуги";
            // 
            // PersonalAccountTextBox
            // 
            this.PersonalAccountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.PersonalAccountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonalAccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalAccountTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PersonalAccountTextBox.Location = new System.Drawing.Point(101, 205);
            this.PersonalAccountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PersonalAccountTextBox.Multiline = true;
            this.PersonalAccountTextBox.Name = "PersonalAccountTextBox";
            this.PersonalAccountTextBox.Size = new System.Drawing.Size(330, 30);
            this.PersonalAccountTextBox.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label7.Location = new System.Drawing.Point(98, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 53;
            this.label7.Text = "Личный счёт";
            // 
            // CommunalPaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(600, 718);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PersonalAccountTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CommunalComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxSum);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommunalPaymentsForm";
            this.Text = "CommunalPaymentsForm";
            this.Load += new System.EventHandler(this.CommunalPaymentsForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommunalPaymentsForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxCVV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxCardTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxSum;
        private System.Windows.Forms.ComboBox CommunalComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PersonalAccountTextBox;
        private System.Windows.Forms.Label label7;
    }
}