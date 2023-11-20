namespace Exe21.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price:F2} (Manufacture date: {Date:d})";
        }
    }
}
