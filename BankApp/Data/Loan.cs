namespace BankApp.Data
{
    public class Loan
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal InterestRate { get; set; }
        public long Term { get; set; }
        public string StartDate { get; set; }

        public Loan()
        {
            
        }
    }

}