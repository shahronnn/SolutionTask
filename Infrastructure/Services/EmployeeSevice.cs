using Domain.Models;

namespace Infrastructure.Services;

public class EmployeeSevice
{
    private List<Employee> _employees;

    public EmployeeSevice()
    {
        _employees=new List<Employee>();
    }
    public List<Employee> GetEmployees()
    {
        return _employees;
    }
    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public int CountEmployee()
    {
        return _employees.Count;
    }
}
