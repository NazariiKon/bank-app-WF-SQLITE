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
    public partial class PayBillsForm : Form
    {
        private Account _account;
        public PayBillsForm(Account account, string address)
        {
            InitializeComponent();
            numericUpDownSum.Maximum = account.Balance;
            textBoxAddress.Text = address;
            _account = account;
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            decimal newBalance = _account.Balance - numericUpDownSum.Value;
            SQLiteRequestHelper.ChangeBalance(newBalance, _account.Id);
            MessageBox.Show("Ви оплатили комунальні послуги на адресу " + textBoxAddress.Text);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
