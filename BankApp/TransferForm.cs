using BankApp.Data;
using BankApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class TransferForm : Form
    {
        private Account _account;
        public TransferForm(Account account)
        {
            InitializeComponent();
            numericUpDownSum.Maximum = account.Balance;
            _account = account;
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM accounts WHERE account_number = @number";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query, textBoxNumber.Text);
            string[] fieldNames = typeof(Account).GetProperties().Select(p => p.Name).ToArray();
            Account accountTransfer = SQLiteReaderHelper.CreateObject<Account>(reader, fieldNames);
            reader.Close();

            Client client = SQLiteRequestHelper.GetClientById(accountTransfer.ClientId);
            DialogResult result = MessageBox.Show("Ви хочете поповнити рахунок для користувача " + client.Name + " на "
                + numericUpDownSum.Value + " гривень?", "Підтвердження", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Deduct from the balance
                decimal newBalance = _account.Balance - numericUpDownSum.Value;
                SQLiteRequestHelper.ChangeBalance(newBalance, _account.Id);

                // Add to the balance
                newBalance = accountTransfer.Balance + numericUpDownSum.Value;
                SQLiteRequestHelper.ChangeBalance(newBalance, accountTransfer.Id);
                query = "INSERT INTO transactions " +
                    "(account_id, transaction_date, transaction_time, amount)" +
                    "VALUES (@account_id, @transaction_date, @transaction_time, @amount);";
                SQLiteReaderHelper.Request(query, _account.Id, 
                    DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), numericUpDownSum.Value);

                MessageBox.Show("Ви поповнили рахунок: " + textBoxNumber.Text +
                " на суму " + numericUpDownSum.Value + " гривень");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
