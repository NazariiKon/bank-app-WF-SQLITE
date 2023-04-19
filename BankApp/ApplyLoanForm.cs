using BankApp.Data;
using BankApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public record Fuu(decimal Rate, decimal Term);

    public partial class ApplyLoanForm : Form
    {
        private long _client_id;
        private Account _account;
        public ApplyLoanForm(long client_id, Account account)
        {
            InitializeComponent();
            _client_id = client_id;
            _account = account;
            comboBoxTerm.Items.Add(new Fuu(decimal.Parse("8,5"), decimal.Parse("12")));
            comboBoxTerm.Items.Add(new Fuu(decimal.Parse("9,25"), decimal.Parse("18")));
            comboBoxTerm.Items.Add(new Fuu(decimal.Parse("10,5"), decimal.Parse("24")));
            comboBoxTerm.Items.Add(new Fuu(decimal.Parse("12,75"), decimal.Parse("36")));
            comboBoxTerm.ValueMember = "Term";
            comboBoxTerm.SelectedIndex = 0;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (checkBoxTerms.Checked)
            {
                string query = "INSERT INTO loans " +
                    "(client_id, interest_rate, term, start_date, loan_amount)" +
                    "VALUES (@client_id, @interest_rate, @term, @start_date, @loan_amount);";
                Fuu fuu = comboBoxTerm.SelectedItem as Fuu;
                SQLiteReaderHelper.Request(query, _client_id,
                    fuu.Rate, fuu.Term, DateTime.Now.ToShortDateString(), numericUpDownSum.Value);

                decimal newBalance = _account.Balance + numericUpDownSum.Value;
                SQLiteRequestHelper.ChangeBalance(newBalance, _account.Id);
                MessageBox.Show("Ви оформили кредит!");
                this.Close();
            }
        }

        private void comboBoxTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fuu fuu = comboBoxTerm.SelectedItem as Fuu;
            labelRate.Text = fuu.Rate.ToString();
        }
    }
}
