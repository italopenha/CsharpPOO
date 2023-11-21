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
            throw new NotImplementedException();
        }
    }
}
