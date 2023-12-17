namespace Exe35.Interfaces
{
    internal interface IOnlinePaymentService
    {
        double Interest(double amount);
        double PaymentFee(double amount, int months);
    }
}
