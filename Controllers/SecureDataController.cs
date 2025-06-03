using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EntraSecuredApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SecureDataController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        return Ok(new { Message = "Vous êtes authentifié via Entra !" });
    }
}
