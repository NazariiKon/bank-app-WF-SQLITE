using System.Data.SQLite;
using BankApp.Data;
using BankApp.Helpers;

namespace BankApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                string query = @"SELECT * FROM clients WHERE Phone = @param";
                SQLiteDataReader reader = SQLiteReaderHelper.Request(query, textBoxPhone.Text);
                if(reader != null)
                {
                    string[] fieldNames = typeof(Client).GetProperties().Select(p => p.Name).ToArray();
                    Client client = SQLiteReaderHelper.CreateObject<Client>(reader, fieldNames);

                    if (client != null)
                    {
                        reader.Close();
                        MainForm mainForm = new MainForm(client);
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                } 
                else
                {
                    RegForm regForm = new RegForm(textBoxPhone.Text);
                    regForm.ShowDialog();
                   
                }
                
            }
        }
    }
}