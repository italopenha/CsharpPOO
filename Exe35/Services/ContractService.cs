using Exe35.Entities;
using Exe35.Interfaces;

namespace Exe35.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            for (int i = 0; i < months; i++)
            {
                double portion = contract.TotalValue / months;
                double simpleInterest = _onlinePaymentService.Interest(portion);
                double paymentFee = _onlinePaymentService.PaymentFee(portion, months);
                portion += simpleInterest + paymentFee;

                Installment installment = new Installment(contract.Date.AddMonths(1), portion);
                contract.Installments.Add(installment);
            }
        }
    }
}
