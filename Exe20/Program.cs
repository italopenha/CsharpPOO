using Exe20.Entities;

namespace Exe20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Digite o número de empregados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do funcionário #{i}:");
                Console.Write("Terceirizado (s/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (ch == 's' || ch == 'S')
                {
                    Console.Write("Despesa adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }   
            }

            Console.WriteLine();

            Console.WriteLine("PAGAMENTOS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2")}");
            }
        }
    }
}
