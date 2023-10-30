using Microsoft.AspNetCore.Mvc;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthoritiesController : ControllerBase
{
    private IAuthorityService _authorityService;

    public AuthoritiesController(IAuthorityService authorityService)
    {
        _authorityService = authorityService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<Authority> authorities = _authorityService.GetAll();
        return Ok(authorities);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        Authority authority = _authorityService.GetAuthority(id);
        if(authority is not null)
            return Ok(authority);
        return NoContent();
    }

    [HttpPost]
    public IActionResult Add(Authority authority)
    {
        Authority newAuthority = _authorityService.Add(authority);
        return Ok(newAuthority);
    }

    [HttpPut]
    public IActionResult Update(Authority authority)
    {
        Authority updatedAuthority = _authorityService.Update(authority);
        return Ok(updatedAuthority);
    }

    [HttpDelete]
    public IActionResult Delete(Authority authority)
    {
        _authorityService.Delete(authority);
        return Ok("Yetki Başarılı ile Silindi");
    }
}