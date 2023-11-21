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
            throw new NotImplementedException();
        }
    }
}
