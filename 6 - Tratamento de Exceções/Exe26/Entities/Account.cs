using Exe26.Entities.Exceptions;

namespace Exe26.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; private set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public double Deposit(double amount)
        {
            return Balance += amount;
        }

        public double WithDraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Saldo insuficiente!");
            }
            if (amount > WithDrawLimit)
            {
                throw new DomainException("Essa quantia excede o limite de saque!");
            }
            return Balance -= amount;
        }
    }
}
