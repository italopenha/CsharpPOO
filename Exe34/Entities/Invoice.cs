﻿namespace Exe34.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"INVOICE:\n" +
                $"Basic payment: {BasicPayment:F2}\n" +
                $"Tax: {Tax:F2}\n" +
                $"Total Payment: {TotalPayment:F2}";
        }
    }
}
