namespace Exe33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sourcePath = @"c:\dev\temp\file1.csv";
                Directory.CreateDirectory(@"c:\dev\temp\out");
                string targetPath = @"c:\dev\temp\out\summary.csv";

                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(';');
                        string name = fields[0];
                        double price = double.Parse(fields[1]);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);

                        sw.WriteLine(product);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
