using Exe21.Entities;

namespace Exe21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do produto #{i}:");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine());

                if (productType == 'u' || productType == 'U')
                {
                    Console.Write("Data de fabricação (DD/MM/AAAA): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                }
                else if (productType == 'i' || productType == 'I')
                {
                    Console.Write("Taxa de alfândega: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();

            Console.WriteLine("Etiquetas de preço:");
            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
