using Exe35.Entities;
using Exe35.Services;
using System.Globalization;

namespace Exe35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());
           
            Contract contract = new Contract(number, date, totalValue);

            ContractService contractService = new ContractService(new PayPalService());

            Console.WriteLine("INSTALLMENTS:");
            contractService.ProcessContract(contract, installments);
        }
    }
}
