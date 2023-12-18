using Exe35.Interfaces;

namespace Exe35.Services
{
    internal class PayPalService : IOnlinePaymentService
    {
        public double Interest(double amount, int months)
        {
            double interest = (amount * 0.01) * months;
            return interest;
        }

        public double PaymentFee(double amount)
        {
            double paymentFee = amount * 0.02;
            return paymentFee;
        }
    }
}
