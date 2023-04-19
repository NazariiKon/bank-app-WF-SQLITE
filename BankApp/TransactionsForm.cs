using BankApp.Data;
using BankApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BankApp
{
    public partial class TransactionsForm : Form
    {
        List<MyTransaction> transactions;

        public TransactionsForm(long id)
        {
            InitializeComponent();
            transactions = readAllTransactions();
            foreach (var item in transactions)
            {
                if (item.AccountId == id)
                {
                    listBoxTransactions.Items.Add(item);
                }
            }
        }

        private List<MyTransaction> readAllTransactions()
        {
            string query = $"SELECT * FROM transactions";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query);
            return SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper.CreateObject<MyTransaction>(r,
                "Id", "AccountId", "TransactionDate", "TransactionTime", "Amount"));
        }
    }
}
