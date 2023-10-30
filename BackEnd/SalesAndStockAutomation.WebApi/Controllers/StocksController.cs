using Microsoft.AspNetCore.Mvc;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StocksController : ControllerBase
{
    private IStockService _stockService;

    public StocksController(IStockService stockService)
    {
        _stockService = stockService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Stock> stocks = _stockService.GetAll();
        return Ok(stocks);
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Stock stock = _stockService.GetById(id);
        if (stock is not null)
            return Ok(stock);
        return NoContent();
    }
    
    [HttpGet("{skip}/{take}")]
    public IActionResult Get(int skip, int take)
    {
        List<Stock> stocks = _stockService.Paging(skip, take);
        return Ok(stocks);
    }

    [HttpPost]
    public IActionResult Add(Stock stock)
    {
        Stock newStock = _stockService.Add(stock);
        return Ok(newStock);
    }
    
    [HttpPut]
    public IActionResult Update(Stock stock)
    {
        Stock updatedStock = _stockService.Update(stock);
        return Ok(updatedStock);
    }
    
    [HttpDelete]
    public IActionResult Delete(Stock stock)
    {
        _stockService.Delete(stock);
        return Ok("Stok Başarı ile Silindi");
    }
}
