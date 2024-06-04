namespace Lab14ex1
{
    internal class EmployeeManagement
    {
        private List<Employee> employees;

        public EmployeeManagement()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine($"Name: {employee.Name} add to list.");
        }


        public void RemoveEmployee(Guid id)
        {
            employees.RemoveAll(e => e.Id == id);
        }

        public void GetNoOfWellPayedEmployees(double sum)
        {
            List<Employee> wellPayedEmployees = employees.FindAll(emp => emp.Salary > sum);
            Console.WriteLine($"There are {wellPayedEmployees.Count} well payed.");
        }

        public void GetEmployeesByDepartment(Department department)
        {
            List<Employee> employeesDep =  employees.FindAll(emp => emp.Department == department);
            Console.WriteLine($"There are {employeesDep.Count} employees in {department} department.");
        }

        public void GetMaxSalary()
        {
            double maxSalary = employees.Max(e => e.Salary);
            List<Employee> maxSalaryList = employees.FindAll(emp => emp.Salary == maxSalary);
            maxSalaryList.ForEach(f => Console.WriteLine($"{f.Name} has max salary"));

        }

        public double GetTotalCost()
        {
            return employees.Sum(e => e.Salary);
        }


        public void GetCostForDepartment(Department department)
        {
            List<Employee> employeesDep = employees.FindAll(emp => emp.Department == department);
            var totalCost = employeesDep.Sum(e => e.Salary);
            Console.WriteLine($"Total cost for department {department} is {totalCost}");
        }
    }
}
