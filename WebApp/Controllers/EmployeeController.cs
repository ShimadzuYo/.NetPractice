using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Models.Employees;


namespace WebApp.Controllers;

[Route("[controller]/[action]")]

public class EmployeeController : Controller
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    
    [HttpGet]
    public IActionResult List()
    {
        var employees = _employeeService.GetEmployees();
        var viewModel = new EmployeeListViewModel
        {
             Employees = employees
        };
        return View(viewModel);
    }
}