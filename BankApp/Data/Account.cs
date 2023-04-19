namespace BankApp.Data
{
    public class Account
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }

}