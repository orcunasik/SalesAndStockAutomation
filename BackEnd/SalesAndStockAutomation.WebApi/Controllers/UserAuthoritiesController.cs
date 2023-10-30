using Microsoft.AspNetCore.Mvc;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserAuthoritiesController : ControllerBase
{
    private IUserAuthorityService _userAuthorityService;

    public UserAuthoritiesController(IUserAuthorityService userAuthorityService)
    {
        _userAuthorityService = userAuthorityService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<UserAuthority> userAuthorities = _userAuthorityService.GetAll();
        return Ok(userAuthorities);
    }

    [HttpGet("{authorityId}/{skip}/{take}")]
    public IActionResult Get(int authorityId, int skip, int take)
    {
        List<Employee> employees = _userAuthorityService.GetEmployeesByAuthorityId(authorityId,skip,take);
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        UserAuthority userAuthority = _userAuthorityService.GetById(id);
        if(userAuthority is not null)
            return Ok(userAuthority);
        return NoContent();
    }

    [HttpPost]
    public IActionResult Add(UserAuthority userAuthority)
    {
        UserAuthority newUserAuthority = _userAuthorityService.Add(userAuthority);
        return Ok(newUserAuthority);
    }

    [HttpPut]
    public IActionResult Update(UserAuthority userAuthority)
    {
        UserAuthority updatedUserAuthority = _userAuthorityService.Update(userAuthority);
        return Ok(updatedUserAuthority);
    }

    [HttpDelete]
    public IActionResult Delete(UserAuthority userAuthority)
    {
        _userAuthorityService.Delete(userAuthority);
        return Ok("Kullanıcı Yetkisi Başarıyla Silindi");
    }
}
