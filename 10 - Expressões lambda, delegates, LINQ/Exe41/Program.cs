using Exe41.Entities;
using System.Globalization;

namespace Exe41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> listEmployees = [];

            using StreamReader sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(',');
                string name = fields[0];
                string email = fields[1];
                double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                listEmployees.Add(new Employee(name, email, salary));
            }

            Console.Write("Enter salary: ");
            double comparasionSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Email of people whose salary is more than " + comparasionSalary.ToString("F2", CultureInfo.InvariantCulture));

            var listEmails = listEmployees.Where(e => e.Salary > comparasionSalary).OrderBy(e => e.Email).Select(e => e.Email);
            foreach (string email in listEmails)
            {
                Console.WriteLine(email);
            }

            var employeesNamesStartingWithM = listEmployees.Where(e => e.Name.StartsWith("M")).Sum(e => e.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + employeesNamesStartingWithM.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
