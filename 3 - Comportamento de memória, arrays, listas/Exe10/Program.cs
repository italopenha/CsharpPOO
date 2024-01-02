namespace Exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Sum(10, 20, 10, 50, 100);

            Console.WriteLine(result);

            int a = 10;
            int triple;

            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}