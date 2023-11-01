namespace Exe08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n) ");
            char resp = char.Parse(Console.ReadLine());
            
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                cb = new ContaBancaria(numero, titular, saldo);
            }
            else
            {
                cb = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(cb);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            cb.Depositar(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            cb.Sacar(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);

            Console.WriteLine();

            Console.Write("Deseja atualizar o nome do titular da conta? (s/n) ");
            resp = char.Parse(Console.ReadLine());
            if ( resp == 's' || resp == 'S')
            {
                Console.Write("Digite o novo nome: ");
                string nome = Console.ReadLine();
                cb.AlterarNome(nome);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);
        }
    }
}