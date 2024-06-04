namespace Lab14ex1
{
    internal class Employee
    {
        public string Name { get; private set; }
        public Guid Id { get; private set; }
        public double Salary { get; private set; }
        public Department Department { get; private set; }

        public Employee(string name, double salary, Department department)
        {
            Name = name;
            Id = Guid.NewGuid();
            Salary = salary;
            Department = department;
        }

        public override string ToString()
        {
            return $"Name: {Name},\nId: {Id},\nSalary: {Salary},\nDepartment: {Department}";
        }
    }
}

