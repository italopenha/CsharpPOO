using Exe18.Entities.Enums;
using System.Text;

namespace Exe18.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem i in Items)
            {
                sum += i.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Data de criação do pedido: {Moment}");
            sb.AppendLine($"Status do pedido: {Status}");
            sb.AppendLine($"Cliente: {Client}");
            sb.AppendLine("Itens do pedido:");
            string items = string.Join("\n", Items);
            sb.AppendLine(items);
            sb.AppendLine($"Preço total: ${Total().ToString("F2")}");
            return sb.ToString();
        }
    }
}
