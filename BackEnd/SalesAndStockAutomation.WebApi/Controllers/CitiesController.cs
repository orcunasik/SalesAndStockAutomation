using FluentNHibernate.Testing.Values;
using Microsoft.AspNetCore.Mvc;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CitiesController : ControllerBase
{
    private ICityService _cityService;

    public CitiesController(ICityService cityService)
    {
        _cityService = cityService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<City> cities = _cityService.GetAll();
        return Ok(cities);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        City city = _cityService.GetById(id);
        if(city is not null)
            return Ok(city);
        return NoContent();
    }

    [HttpGet("{parentId}/{skip}/{take}")]
    public IActionResult Get(int parentId, int skip, int take)
    {
        List<City> cities = _cityService.GetCityByParent(parentId,skip,take);
        return Ok(cities);
    }

    [HttpPost]
    public IActionResult Add(City city)
    {
        City newCity = _cityService.Add(city);
        return Ok(newCity);
    }

    [HttpPut]
    public IActionResult Update(City city)
    {
        City updatedCity = _cityService.Update(city);
        return Ok(updatedCity);
    }

    [HttpDelete]
    public IActionResult Delete(City city)
    {
        _cityService.Delete(city);
        return Ok("Şehir Başarı ile Silindi");
    }

    //[HttpPost]
    //public IActionResult Delete(List<City> cities)
    //{
    //    _cityService.MultiDelete(cities);
    //    return Ok("Şehirler Başarı ile Silindi");
    //}
}
