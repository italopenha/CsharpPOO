namespace Exe12
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee() { }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            double increase = Salary * percentage / 100;
            Salary += increase;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary:F2}";
        }
    }
}
