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
    public partial class TopUpForm : Form
    {
        private Account _account;
        public TopUpForm(Account account, string phone)
        {
            InitializeComponent();
            numericUpDownSum.Maximum = account.Balance;
            textBoxPhone.Text = phone;
            _account = account;
        }
        private void buttonPay_Click(object sender, EventArgs e)
        {
            decimal newBalance = _account.Balance - numericUpDownSum.Value;
            SQLiteRequestHelper.ChangeBalance(newBalance, _account.Id);
            MessageBox.Show("Ви поповнили телефон: " + textBoxPhone.Text +
                " на суму " + numericUpDownSum.Value + " гривень");
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
