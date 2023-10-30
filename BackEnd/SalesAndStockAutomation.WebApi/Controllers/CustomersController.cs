using Microsoft.AspNetCore.Mvc;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private ICustomerService _customerService;

    public CustomersController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Customer> customers = _customerService.GetAll();
        return Ok(customers);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Customer customer = _customerService.GetById(id);
        if(customer is not null)
            return Ok(customer);
        return NoContent();
    }

    [HttpGet("{skip}/{take}")]
    public IActionResult Get(int skip, int take)
    {
        List<Customer> customers = _customerService.Paging(skip, take);
        return Ok(customers);
    }

    [HttpPost]
    public IActionResult Add(Customer customer)
    {
        Customer newCustomer = _customerService.Add(customer);
        return Ok(newCustomer);
    }

    [HttpPut]
    public IActionResult Update(Customer customer)
    {
        Customer updatedCustomer = _customerService.Update(customer);
        return Ok(updatedCustomer);
    }

    [HttpDelete]
    public IActionResult Delete(Customer customer)
    {
        _customerService.Delete(customer);
        return Ok("Müşteri Bilgisi Başarı ile Silindi");
    }
}
