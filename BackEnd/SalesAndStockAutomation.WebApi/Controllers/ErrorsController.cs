using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace SalesAndStockAutomation.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ErrorsController : ControllerBase
{
    //public IActionResult Error()
    //{
    //    IExceptionHandlerFeature context = HttpContext.Features.Get<IExceptionHandlerFeature>();
    //    return BadRequest(context.Error.Message);
    //}
}
