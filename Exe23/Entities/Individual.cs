namespace Exe23.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public override double Tax()
        {
            throw new NotImplementedException();
        }
    }
}
