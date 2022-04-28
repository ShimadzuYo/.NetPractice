using Application.Interfaces;
using Domain;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class EmployeeService : IEmployeeService
{
    private readonly ApplicationDbContext _dbContext;

    public EmployeeService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public List<Employee> GetEmployees()
    {
        return _dbContext.Employees.ToList();
    }

    public Employee GetEmployeeById(int id)
    {
        var employee = _dbContext.Employees.FirstOrDefault(x => x.Id == id);
        return employee;
    }

    public void UpdateEmployee(int id, Employee newEmployee)
    {
        var employee = _dbContext.Employees.FirstOrDefault(x => x.Id == id);
        if (employee == null)
            throw new ArgumentException("Project not found!");
        employee.FirstName = newEmployee.FirstName;
        employee.LastName = newEmployee.LastName;
        employee.MiddleName = newEmployee.MiddleName;
        employee.Email = newEmployee.Email;

        _dbContext.SaveChanges();
    }

    public void DeleteEmployee(int id)
    {
        var employee = _dbContext.Employees.FirstOrDefault(x => x.Id == id);
        if (employee is null)
            return;
        _dbContext.Employees.Remove(employee);
        _dbContext.SaveChanges();
    }
}