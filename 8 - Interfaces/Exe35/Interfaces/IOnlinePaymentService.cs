﻿namespace Exe35.Interfaces
{
    internal interface IOnlinePaymentService
    {
        double Interest(double amount, int months);
        double PaymentFee(double amount);
    }
}
