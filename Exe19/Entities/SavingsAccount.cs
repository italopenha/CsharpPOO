namespace Exe19.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRating { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRating) : base(number, holder, balance)
        {
            InterestRating = interestRating;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRating;
        }
    }
}
