namespace Exe23.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; private set; }
        public override double Tax()
        {
            throw new NotImplementedException();
        }
    }
}
