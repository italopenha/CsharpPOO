namespace Exe23.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; private set; }
        public override double Tax()
        {
            throw new NotImplementedException();
        }
    }
}
