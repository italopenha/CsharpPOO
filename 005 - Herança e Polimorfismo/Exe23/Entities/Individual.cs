namespace Exe23.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; private set; }

        public Individual() { }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double rate = 0.0;
            double tax = 0.0;

            switch (AnualIncome)
            {
                case < 20000.00:
                    rate = 0.15;

                    if (HealthExpenditures > 0.0)
                    {
                        tax = (AnualIncome * rate) - (HealthExpenditures * 0.5);
                    }
                    else
                    {
                        tax = AnualIncome * rate;
                    }
                    break;
                case >= 20000.00:
                    rate = 0.25;

                    if (HealthExpenditures > 0.0)
                    {
                        tax = (AnualIncome * rate) - (HealthExpenditures * 0.5);
                    }
                    else
                    {
                        tax = AnualIncome * rate;
                    }
                    break;
            }
            return tax;
        }

        public override string ToString()
        {
            return $"{Name}: $ {Tax():F2}";
        }
    }
}
