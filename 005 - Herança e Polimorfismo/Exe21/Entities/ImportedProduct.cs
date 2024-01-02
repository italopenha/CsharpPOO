﻿namespace Exe21.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice():F2} (Customs fee: $ {CustomsFee:F2})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
