using System.Collections.Generic;

namespace Exe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string>() { "Maria", "Alex" };

            list.Add("Tom");
            list.Add("Maria");
            list.Add("Ana");
            list.Insert(2, "Marco");
            list.Add("Alex");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list3 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------");
            foreach(string obj in list3)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("----------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}