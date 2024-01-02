namespace Exe07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double dolaresComprados = double.Parse(Console.ReadLine());

            double conversao = ConversorDeMoedas.Converter(cotacao, dolaresComprados);

            Console.WriteLine($"Valor a ser pago em reais = {conversao:F2}");
        }
    }
}