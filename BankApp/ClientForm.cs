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
    public partial class ClientForm : Form
    {
        private Client _originalClient;
        public ClientForm(Client client)
        {
            InitializeComponent();
            if (client != null )
            {
                textBoxName.Text = client.Name;
                textBoxPhone.Text = client.Phone;
                textBoxAddress.Text = client.Address;
                textBoxWork.Text = client.Employment;
                _originalClient = client;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Сравниваем текущие значения текстовых полей с оригинальными значениями
            if (textBoxName.Text != _originalClient.Name ||
                textBoxPhone.Text != _originalClient.Phone ||
                textBoxAddress.Text != _originalClient.Address ||
                textBoxWork.Text != _originalClient.Employment)
            {
                // Выполняем обновление в базе данных
                string query = $"UPDATE clients SET Name = @name, Phone = @phone, Address = @address, " +
                    $"Employment = @employment WHERE Id = @id";
                // Выполняем запрос с помощью объекта SQLiteCommand
                SQLiteReaderHelper.Request(query, textBoxName.Text, textBoxPhone.Text,
                    textBoxAddress.Text, textBoxWork.Text, _originalClient.Id);
                MessageBox.Show("Зміни прийняті!");
                DialogResult = DialogResult.OK;
            } 
            else
            {
                DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }
    }
}
