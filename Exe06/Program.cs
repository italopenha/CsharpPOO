namespace Exe06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());

            a.NotaFinal();
            a.AprovadoOuReprovado();

            Console.WriteLine();

            Console.WriteLine(a);

            if (a.Resultado == "REPROVADO")
                Console.WriteLine($"FALTARAM {60 - a.NotaFinal():F2} PONTOS");

        }
    }
}