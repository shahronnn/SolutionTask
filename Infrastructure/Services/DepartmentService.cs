using Domain.Models;

namespace Infrastructure.Services;

public class DepartmentSevice
{
    private List<Department> _department;

    public DepartmentSevice()
    {
        _department=new List<Department>();
    }
    public List<Department> GetDepartments()
    {
        return _department;
    }
    public void AddDepartment(Department department)
    {
        _department.Add(department);
    }

    public int CountDepartment()
    {
        return _department.Count;
    }
}