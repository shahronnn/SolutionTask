using Domain.Models;
using Infrastructure.Services;

var empService=new EmployeeSevice();

for (int i = 1; i < 3; i++)
{
    var emp=new Employee();
    System.Console.WriteLine($"Employee {i}");
    System.Console.Write("Enter your firstname : ");
    emp.FirstName=Console.ReadLine();
    System.Console.Write("Enter your lastname : ");
    emp.LastName=Console.ReadLine();
    System.Console.Write("Enter your salary : ");
    emp.Salary=Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter your birthdate : ");
    emp.BirthDay=new DateTime(
        Convert.ToInt32(Console.ReadLine()),
        Convert.ToInt32(Console.ReadLine()),
        Convert.ToInt32(Console.ReadLine())
    );
    System.Console.Write("Enter name of your department : ");
    emp.Department=new Department(Console.ReadLine());

    empService.AddEmployee(emp);
    List<Employee> listOfEmployees = empService.GetEmployees();
    foreach (var employee in listOfEmployees)
    {
        System.Console.WriteLine();
        System.Console.WriteLine(employee.FirstName);
        System.Console.WriteLine(employee.LastName);
        System.Console.WriteLine(employee.BirthDay.ToShortDateString());
        System.Console.WriteLine(employee.Salary);
        System.Console.WriteLine(employee.Department.Name);
        System.Console.WriteLine("|-------------------------------------|");
    }
}