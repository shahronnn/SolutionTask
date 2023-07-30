namespace Domain.Models;

public class Department
{
    public Department(string name)
    {
        Name=name;
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public Employee Manager { get; set; }
}
