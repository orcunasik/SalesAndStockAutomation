using Microsoft.AspNetCore.Mvc;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Product> products = _productService.GetAll();
        return Ok(products);
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Product product = _productService.GetById(id);
        if (product is not null)
            return Ok(product);
        return NoContent();
    }
    
    [HttpGet("{categoryId}/{skip}/{take}")]
    public IActionResult Get(int categoryId, int skip, int take)
    {
        List<Product> products = _productService.GetProductsByCategory(categoryId, skip, take);
        return Ok(products);
    }

    [HttpPost]
    public IActionResult Add(Product product)
    {
        Product newProduct = _productService.Add(product);
        return Ok(newProduct);
    }

    [HttpPut]
    public IActionResult Update(Product product)
    {
        Product updatedaProduct = _productService.Update(product);
        return Ok(updatedaProduct);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        Product product = _productService.GetById(id);
        _productService.Delete(product);
        return Ok("Ürün Başarı ile Silindi");
    }
}
