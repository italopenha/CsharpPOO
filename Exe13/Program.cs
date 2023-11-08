namespace Exe013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Main diagonal:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }

            Console.WriteLine();

            int negativeNumbers = 0;

            foreach (int i in mat)
            {
                if (i < 0)
                {
                    negativeNumbers++;
                }
            }

            Console.WriteLine($"Negative numbers = {negativeNumbers}");
        }
    }
}