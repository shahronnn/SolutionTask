namespace Domain.Models;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDay { get; set; }
    public decimal Salary { get; set; }
    public Department Department { get; set; }
}
