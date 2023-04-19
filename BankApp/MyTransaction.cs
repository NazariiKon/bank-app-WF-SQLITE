namespace BankApp
{
    public class MyTransaction
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionTime { get; set; }
        public decimal Amount { get; set; }

        public override string ToString()
        {
            return $"Дата час: {TransactionDate} {TransactionTime} Сума: {Amount}";
        }
    }

}