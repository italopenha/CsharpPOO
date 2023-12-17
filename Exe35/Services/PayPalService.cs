using Exe35.Interfaces;

namespace Exe35.Services
{
    internal class PayPalService : IOnlinePaymentService
    {
        public double Interest(double amount)
        {
            double interest = amount * 0.01;
            return interest;
        }

        public double PaymentFee(double amount, int months)
        {
            double paymentFee = (amount * 0.02) * months;
            return paymentFee;
        }
    }
}
