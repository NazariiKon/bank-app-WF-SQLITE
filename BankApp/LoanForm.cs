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
    public partial class LoanForm : Form
    {
        private Loan _loan;
        private Account _account;
        public LoanForm(SQLiteDataReader reader, Account account)
        {
            InitializeComponent();
            string[] fieldNames = typeof(Loan).GetProperties().Select(p => p.Name).ToArray();
            Loan loan = SQLiteReaderHelper.CreateObject<Loan>(reader, fieldNames);
            reader.Close();
            _account = account;

            if (loan != null)
            {
                textBoxSum.Text = loan.LoanAmount.ToString();
                textBoxRate.Text = loan.InterestRate.ToString();
                textBoxTermin.Text = loan.Term.ToString();
                textBoxDate.Text = loan.StartDate;
                _loan = loan;
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            double sum = decimal.ToInt16(_loan.LoanAmount / _loan.Term + _loan.InterestRate);
            DialogResult result = MessageBox.Show("Ви хочете внести місячний платіж за кредит ("
            + sum + " гривень)?", "Підтвердження",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                decimal newSum = _loan.LoanAmount - (decimal)sum;
                textBoxSum.Text = newSum.ToString();
                SQLiteRequestHelper.ChangeBalance(_account.Balance - (decimal)sum, _account.Id);

                string query = $"UPDATE loans SET loan_amount = @newSum WHERE Id = @id";
                SQLiteReaderHelper.Request(query, newSum, _loan.Id);
            }
            
        }
    }
}
