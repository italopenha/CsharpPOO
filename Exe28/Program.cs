namespace Exe28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                //sr = File.OpenText(path); alternativa ao filestream
                while(!sr.EndOfStream) // para ler o arquivo inteiro
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
