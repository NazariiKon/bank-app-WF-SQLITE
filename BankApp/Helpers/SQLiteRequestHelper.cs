using BankApp.Data;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Helpers
{
    public static class SQLiteRequestHelper
    {
        public static Client GetClientById(long id)
        {
            string query = $"SELECT * FROM clients WHERE id = @id";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query, id);
            string[] fieldNames = typeof(Client).GetProperties().Select(p => p.Name).ToArray();
            Client client = SQLiteReaderHelper.CreateObject<Client>(reader, fieldNames);
            reader.Close();
            return client;
        }

        public static Client GetClientByPhone(string phone)
        {
            string query = $"SELECT * FROM clients WHERE Phone = @phone";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query, phone);
            string[] fieldNames = typeof(Client).GetProperties().Select(p => p.Name).ToArray();
            Client client = SQLiteReaderHelper.CreateObject<Client>(reader, fieldNames);
            reader.Close();
            return client;
        }


        public static Account GetAccountByClientId(long id)
        {
            string query = @"SELECT * FROM accounts WHERE client_id = @param";
            SQLiteDataReader reader = SQLiteReaderHelper.Request(query, id);
            string[] fieldNames = typeof(Account).GetProperties().Select(p => p.Name).ToArray();
            Account account = SQLiteReaderHelper.CreateObject<Account>(reader, fieldNames);
            reader.Close();
            return account;
        }

        public static void ChangeBalance(decimal newBalance, long account_id)
        {
            string query = $"UPDATE accounts SET balance = @newBalance WHERE Id = @id";
            SQLiteReaderHelper.Request(query, newBalance, account_id);
        }
    }
}
