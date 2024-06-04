using Lab14ex1;

var emp1 = new Employee("Employee1", 2800, Department.Testing);
var emp2 = new Employee("Employee2", 1200, Department.Development);
var emp3 = new Employee("Employee3", 2300, Department.Development);
var emp4 = new Employee("Employee4", 1600, Department.Logistics);
var emp5 = new Employee("Employee5", 1600, Department.HumanResources);
var emp6 = new Employee("Employee6", 2800, Department.Development);

Console.WriteLine(emp5.ToString());
Console.WriteLine();

var management = new EmployeeManagement();

management.AddEmployee(emp1);
management.AddEmployee(emp2);
management.AddEmployee(emp3);
management.AddEmployee(emp4);
management.AddEmployee(emp5);
management.AddEmployee(emp6);

Console.WriteLine();
management.GetEmployeesByDepartment(Department.Development);

management.GetNoOfWellPayedEmployees(2000);
management.GetMaxSalary();
Console.WriteLine($"Total cost is {management.GetTotalCost()}");

management.GetCostForDepartment(Department.Development);