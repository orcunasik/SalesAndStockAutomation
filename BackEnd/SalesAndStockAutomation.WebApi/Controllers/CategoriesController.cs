using Microsoft.AspNetCore.Mvc;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Category> categories = _categoryService.GetAll();
        return Ok(categories);
    }

    [HttpGet("{skip}/{take}")]
    public IActionResult Get(int skip, int take)
    {
        List<Category> categories = _categoryService.Paging(skip, take);
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Category category = _categoryService.GetById(id);
        if (category is not null)
            return Ok(category);
        return NoContent();
    }

    [HttpPost]
    public IActionResult Add(Category category)
    {
        Category newCategory = _categoryService.Add(category);
        return Ok(newCategory);
    }

    [HttpPut]
    public IActionResult Update(Category category)
    {
        Category updatedCategory = _categoryService.Update(category);
        return Ok(updatedCategory);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        Category category = _categoryService.GetById(id);
        _categoryService.Delete(category);
        return Ok("Kategori Başarılı ile Silindi");
    }
}
