using Exe26.Entities;
using Exe26.Entities.Exceptions;

namespace Exe26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite os dados da conta:");
                Console.Write("Número: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string holder = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: ");
                double withDrawLimit = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Account acc = new Account(number, holder, balance, withDrawLimit);

                Console.Write("Digite uma quantia para sacar: ");
                double amount = double.Parse(Console.ReadLine());

                acc.WithDraw(amount);

                Console.Write($"Novo saldo: {acc.Balance:F2}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
