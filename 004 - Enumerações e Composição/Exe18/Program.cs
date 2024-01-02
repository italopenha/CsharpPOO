using Exe18.Entities;
using Exe18.Entities.Enums;

namespace Exe18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do cliente:");
            Console.Write("Nome: ");
            string clientName = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(clientName, email, birthDate);

            Console.WriteLine("Digite os dados do pedido:");
            DateTime moment = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("Quantos itens tem nesse pedido? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(moment, status, client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite os dados do item #{i}");
                Console.Write("Nome do produto: ");
                string productName = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double productPrice = double.Parse(Console.ReadLine());
                double itemPrice = productPrice;
                Console.Write("Quantidade: ");
                int itemQuantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(itemQuantity, itemPrice, product);
                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("RESUMO DO PEDIDO:");
            Console.WriteLine(order);
        }
    }
}
