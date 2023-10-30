using Microsoft.AspNetCore.Mvc;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SalesController : ControllerBase
{
    private ISaleService _saleService;

    public SalesController(ISaleService saleService)
    {
        _saleService = saleService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Sale> sales = _saleService.GetAll();
        return Ok(sales);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Sale sale = _saleService.GetById(id);
        if (sale is not null)
            return Ok(sale);
        return NoContent();
    }

    [HttpGet("{skip}/{take}")]
    public IActionResult Get(int skip, int take)
    {
        List<Sale> sales = _saleService.Paging(skip, take);
        return Ok(sales);
    }

    [HttpPost]
    public IActionResult Add(Sale sale)
    {
        Sale newSale = _saleService.Add(sale);
        return Ok(newSale);
    }
    
    [HttpPut]
    public IActionResult Update(Sale sale)
    {
        Sale updatedSale = _saleService.Update(sale);
        return Ok(updatedSale);
    }
    
    [HttpDelete]
    public IActionResult Delete(Sale sale)
    {
        _saleService.Delete(sale);
        return Ok("Satış Başarı ile Silindi");
    }
}
