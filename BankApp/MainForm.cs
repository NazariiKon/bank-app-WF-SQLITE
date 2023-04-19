using BankApp.Data;
using BankApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BankApp
{
    public partial class MainForm : Form
    {
        private Account _account;
        private Client _client;

        public MainForm(Client client)
        {
            InitializeComponent();
            _account = SQLiteRequestHelper.GetAccountByClientId(client.Id);
            _client = client;
            if (_account != null)
            {
                labelBalance.Text = _account.Balance.ToString();
                textBoxNumber.Text = _account.AccountNumber.ToString();
            }
        }


        private void buttonClientInfo_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(_client);
            DialogResult result = clientForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string query = @"SELECT * FROM clients WHERE Id = @param";
                SQLiteDataReader reader = SQLiteReaderHelper.Request(query, _client.Id);
                string[] fieldNames = typeof(Client).GetProperties().Select(p => p.Name).ToArray();
                _client = SQLiteReaderHelper.CreateObject<Client>(reader, fieldNames);
            }
        }

        private void buttonPayBills_Click(object sender, EventArgs e)
        {
            PayBillsForm payBillsForm = new PayBillsForm(_account, _client.Address);
            DialogResult result = payBillsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                _account = SQLiteRequestHelper.GetAccountByClientId(_client.Id);
                labelBalance.Text = _account.Balance.ToString();
            }
        }

        private void buttonTopUp_Click(object sender, EventArgs e)
        {
            TopUpForm topUpForm = new TopUpForm(_account, _client.Phone);
            DialogResult result = topUpForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                _account = SQLiteRequestHelper.GetAccountByClientId(_client.Id);
                labelBalance.Text = _account.Balance.ToString();
            }
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm(_account);
            DialogResult result = transferForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                _account = SQLiteRequestHelper.GetAccountByClientId(_client.Id);
                labelBalance.Text = _account.Balance.ToString();
            }
        }

        private void buttonLoans_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM loans WHERE client_id = @id";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query, _client.Id);
            if (reader == null)
            {
                ApplyLoanForm applyLoanForm = new ApplyLoanForm(_client.Id, _account);
                DialogResult result = applyLoanForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _account = SQLiteRequestHelper.GetAccountByClientId(_client.Id);
                    labelBalance.Text = _account.Balance.ToString();
                }
            }
            else
            {
                LoanForm loanForm = new LoanForm(reader, _account);
                DialogResult result = loanForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _account = SQLiteRequestHelper.GetAccountByClientId(_client.Id);
                    labelBalance.Text = _account.Balance.ToString();
                }
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            TransactionsForm transactionsForm = new TransactionsForm(_account.Id);
            transactionsForm.Show();
        }
    }
}
