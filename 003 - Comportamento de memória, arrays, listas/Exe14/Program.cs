namespace Exe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"Position {i},{j}:");

                        if (j > 0)
                        {
                            int left = mat[i, j - 1];
                            Console.WriteLine($"Left: {left}");
                        }

                        if (j < n - 1)
                        {
                            int right = mat[i, j + 1];
                            Console.WriteLine($"Right: {right}");
                        }

                        if (i > 0)
                        {
                            int up = mat[i - 1, j];
                            Console.WriteLine($"Up: {up}");
                        }

                        if (i < m - 1)
                        {
                            int down = mat[i + 1, j];
                            Console.WriteLine($"Down: {down}");
                        }
                    }
                }
            }
        }
    }
}