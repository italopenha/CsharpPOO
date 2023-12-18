using Exe35.Entities;
using Exe35.Interfaces;

namespace Exe35.Services
{
    internal class ContractService
    {
        private readonly IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            for (int i = 1; i <= months; i++)
            {
                double portion = contract.TotalValue / months;
                double simpleInterest = _onlinePaymentService.Interest(portion, i);
                double paymentFee = _onlinePaymentService.PaymentFee(portion + simpleInterest);
                portion += simpleInterest + paymentFee;

                Installment installment = new Installment(contract.Date.AddMonths(i), portion);
                Console.WriteLine(installment);
            }
        }
    }
}
