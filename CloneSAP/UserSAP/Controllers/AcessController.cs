using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UserSAP.Controllers;

[ApiController]
[Route("{Controller}")]
public class AcessController : ControllerBase
{
    [HttpGet]
    [Authorize(Policy = "IdadeMinima")]
    public IActionResult Get()
    {
        return Ok("AcessoPermitido");
    }
}
