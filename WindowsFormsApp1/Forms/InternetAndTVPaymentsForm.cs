﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1.Forms
{
    public partial class InternetAndTVPaymentsForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        Random rand = new Random();
        DataTable table = new DataTable();
        ValidationForm validation = new ValidationForm();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        public InternetAndTVPaymentsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InternetAndTVPaymentsForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void InternetAndTVPaymentsForm_Load(object sender, EventArgs e)
        {
            TextBoxCard.Text = DataStorage.cardNumber;
            var queryChooseOperator = $"select id_service, serviceName from clientServices where serviceType = 'Internet'";
            SqlDataAdapter commandChooseOperator = new SqlDataAdapter(queryChooseOperator, database.getConnection());
            database.openConnection();
            DataTable operators = new DataTable();
            commandChooseOperator.Fill(operators);
            InternetComboBox.DataSource = operators;
            InternetComboBox.ValueMember = "id_service";
            InternetComboBox.DisplayMember = "serviceName";
            database.closeConnection();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            var PersonalAccount = PersonalAccountTextBox.Text;
            double sum = Convert.ToDouble(TextBoxSum.Text);
            var cardNumber = TextBoxCard.Text;
            var cardCVV = TextBoxCVV.Text;
            var cardDate = TextBoxCardTo.Text;
            var cardCVVCheck = "";
            var cardDateCheck = "";
            double cardBalanceCheck = 0;
            bool error = false;
            string cardCurrency = "";

            if (!Regex.IsMatch(PersonalAccountTextBox.Text, "^[0-9]{10}$"))
            {
                MessageBox.Show("Введите корректно ваш номер лицевого счёта", caption, btn, ico);
                PersonalAccountTextBox.Select();
                return;
            }

            var gueryCheckCard = $"select bank_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%M'), '/', FORMAT(bank_card_date, '%y')), bank_card_balance, bank_card_currency from bank_card where bank_card_number = '{cardNumber}'";
            SqlCommand commandCheckCard = new SqlCommand(gueryCheckCard, database.getConnection());
            database.openConnection();
            SqlDataReader reader = commandCheckCard.ExecuteReader();

            while (reader.Read())
            {
                cardCVVCheck = reader[0].ToString();
                cardDateCheck = reader[1].ToString();
                cardBalanceCheck = Convert.ToDouble(reader[2].ToString());
                cardCurrency = reader[3].ToString();
            }
            reader.Close();

            if (cardCurrency != "RUB")
            {
                MessageBox.Show("Оплата услуг Интернет и ТВ может производиться только в рублях", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (cardCVV != cardCVVCheck)
            {
                MessageBox.Show("Ошибка. Некорректно введён CVV-код", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (cardDate != cardDateCheck)
            {
                MessageBox.Show("Ошибка. Некорректно введена дата карты", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (sum > cardBalanceCheck)
            {
                MessageBox.Show("Ошибка. Недостаточно средств для совершения операции", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (error == false)
            {
                DataStorage.bankCard = TextBoxCard.Text;
                validation.ShowDialog();

                if (DataStorage.attempts > 0)
                {
                    DateTime transactionDate = DateTime.Now;
                    var transactionNumber = "P";
                    for (int i = 0; i < 10; i++)
                    {
                        transactionNumber += Convert.ToString(rand.Next(0, 10));
                    }

                    var queryTransaction1 = $"update bank_card set bank_card_balance = bank_card_balance - '{sum}' where bank_card_number = '{cardNumber}'";

                    var queryTransaction2 = $"insert into transactions(transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) values('Оплата услуг Интернет и ТВ', '{InternetComboBox.GetItemText(InternetComboBox.SelectedItem)}', '{transactionDate}', '{transactionNumber}', '{sum}', (select id_bank_card from bank_card where bank_card_number = '{cardNumber}'))";

                    var queryTransaction3 = $"update clientServices set serviceBalance = serviceBalance + '{sum}' where serviceName = '{InternetComboBox.GetItemText(InternetComboBox.SelectedItem)}' and serviceType = 'Internet'";

                    var queryTransaction4 = $"insert into clientPersonalAccount(personal_account, id_service, id_client) values('{PersonalAccountTextBox.Text}', (select id_service from clientServices where serviceName = '{InternetComboBox.GetItemText(InternetComboBox.SelectedItem)}'), '{DataStorage.idClient}')";

                    var command1 = new SqlCommand(queryTransaction1, database.getConnection());
                    var command2 = new SqlCommand(queryTransaction2, database.getConnection());
                    var command3 = new SqlCommand(queryTransaction3, database.getConnection());
                    var command4 = new SqlCommand(queryTransaction4, database.getConnection());

                    database.openConnection();

                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    command4.ExecuteNonQuery();

                    database.closeConnection();

                    Close();
                }
            }
        }
    }
}
