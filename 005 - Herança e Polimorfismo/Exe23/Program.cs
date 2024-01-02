using Exe23.Entities;

namespace Exe23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Digite o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite os dados do contribuinte #{i}:");
                Console.Write("Pessoa física ou jurídica (f/j)? ");
                char taxPayerType = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Rendimento anual: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (taxPayerType == 'f' || taxPayerType == 'F')
                {
                    Console.Write("Despesas com saúde: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (taxPayerType == 'j' || taxPayerType == 'j')
                {
                    Console.Write("Número de funcionários: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            double sum = 0.0;

            Console.WriteLine();
            Console.WriteLine("Taxas pagas:");
            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer);
                sum += taxPayer.Tax();
            }

            Console.WriteLine();
            Console.Write("Total de imposto pago: ");
            Console.WriteLine($"$ {sum:F2}");
        }
    }
}
