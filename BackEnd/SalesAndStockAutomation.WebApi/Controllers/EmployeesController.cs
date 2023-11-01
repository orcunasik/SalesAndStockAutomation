using Microsoft.AspNetCore.Mvc;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private IEmployeeService _employeeService;

    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Employee> employees = _employeeService.GetAll();
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Employee employee = _employeeService.GetById(id);
        if (employee is not null)
            return Ok(employee);
        return NoContent();
    }

    [HttpPost]
    public IActionResult Add(Employee employee)
    {
        Employee newEmployee = _employeeService.Add(employee);
        return Ok(employee);
    }

    [HttpPut]
    public IActionResult Update(Employee employee)
    {
        Employee updatedEmployee = _employeeService.Update(employee);
        return Ok(updatedEmployee);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        Employee employee = _employeeService.GetById(id);
        _employeeService.Delete(employee);
        return Ok("Personel Bilgisi Başarı ile Silindi");
    }
}
