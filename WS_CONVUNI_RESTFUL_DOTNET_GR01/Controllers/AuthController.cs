using Microsoft.AspNetCore.Mvc;
using WS_CONVUNI_RESTFUL_DOTNET_GR01.Dtos;
using WS_CONVUNI_RESTFUL_DOTNET_GR01.Services;

namespace WS_CONVUNI_RESTFUL_DOTNET_GR01.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(AuthService service) : ControllerBase
{
    private readonly AuthService _service = service;

    [HttpPost("Login")]
    [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status200OK)]
    public IActionResult Login([FromBody] LoginRequest dto)
    {
        var result = _service.Login(dto);
        return Ok(result);
    }
}