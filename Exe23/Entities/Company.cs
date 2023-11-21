namespace Exe23.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; private set; }

        public Company() { }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double rate = 0.0;
            double tax = 0.0;

            switch (NumberOfEmployees)
            {
                case <= 10:
                    rate = 0.16;
                    tax = AnualIncome * rate;
                    break;
                case > 10:
                    rate = 0.14;
                    tax = AnualIncome * rate;
                    break;
            }
            return tax;
        }
    }
}
