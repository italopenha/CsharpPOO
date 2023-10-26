namespace Exe04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Digite a largura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo:");
            r.Altura = double.Parse(Console.ReadLine());

            r.Area();
            r.Perimetro();
            r.Diagonal();

            Console.WriteLine(r);
        }
    }
}