using Exe22.Entities;
using Exe22.Entities.Enums;

namespace Exe22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Digite a quantidade de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados da figura {i}:");
                Console.Write("Retângulo ou círculo (r/c)? ");
                char shapeType = char.Parse(Console.ReadLine());
                Console.Write("Cor (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (shapeType == 'r' || shapeType == 'R')
                {
                    Console.Write("Largura: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Raio: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Áreas das figuras:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}
