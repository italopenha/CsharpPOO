namespace Exe38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> listA = new HashSet<int>();
            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0;  i < a; i++)
            {
                int x = int.Parse(Console.ReadLine());
                listA.Add(x);
            }

            HashSet<int> listB = new HashSet<int>();
            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                int x = int.Parse(Console.ReadLine());
                listB.Add(x);
            }

            HashSet<int> listC = new HashSet<int>();
            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                int x = int.Parse(Console.ReadLine());
                listC.Add(x);
            }

            HashSet<int> total = new HashSet<int>();
            total.UnionWith(listA);
            total.UnionWith(listB);
            total.UnionWith(listC);
                        
            Console.WriteLine("Total students: " + total.Count);
        }
    }
}
