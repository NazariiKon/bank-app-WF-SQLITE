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
    public partial class RegForm : Form
    {
        public RegForm(string phone)
        {
            InitializeComponent();
            textBoxPhone.Text = phone;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO clients " +
                       "(name, address, phone, employment) " +
                       "VALUES (@name, @address, @phone, @employment);";
            SQLiteReaderHelper.Request(query, textBoxName.Text, textBoxAddress.Text, 
                textBoxPhone.Text, textBoxWork.Text);
            Client client = SQLiteRequestHelper.GetClientByPhone(textBoxPhone.Text);
            query = "INSERT INTO accounts " +
                       "(client_id, account_number, balance) " +
                       "VALUES(@client_id, @account_number, @balance); ";
            Random rand = new Random();
            long number = (long)(rand.NextDouble() * Math.Pow(10, 16));
            SQLiteReaderHelper.Request(query, client.Id, number, 0);

            MessageBox.Show("Вас зареєстровано. Увійдіть в свій аккаунт.");
            this.Close();

        }
    }
}
