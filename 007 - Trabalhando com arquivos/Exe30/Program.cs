namespace Exe30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"c:\temp\file1.txt";
            string targetpath = @"c:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using(StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
