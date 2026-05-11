using Microsoft.AspNetCore.Mvc;
using WS_CONVUNI_REST_DOTNET_GR01.Dtos;
using WS_CONVUNI_REST_DOTNET_GR01.Services;

namespace WS_CONVUNI_REST_DOTNET_GR01.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UnitConversionController : ControllerBase
{
    private readonly UnitConversionService _service;

    public UnitConversionController(UnitConversionService service)
    {
        _service = service;
    }

    [HttpPost("Mass")]
    [ProducesResponseType(typeof(UnitConversionResponse), StatusCodes.Status200OK)]
    public IActionResult ConvertMass([FromBody] MassRequest dto)
    {
        var result = _service.ConvertMass(dto);
        return Ok(result);
    }

    [HttpPost("Length")]
    [ProducesResponseType(typeof(UnitConversionResponse), StatusCodes.Status200OK)]
    public IActionResult ConvertLength([FromBody] LengthRequest dto)
    {
        var result = _service.ConvertLength(dto);
        return Ok(result);
    }

    [HttpPost("Temperature")]
    [ProducesResponseType(typeof(UnitConversionResponse), StatusCodes.Status200OK)]
    public IActionResult ConvertTemperature([FromBody] TemperatureRequest dto)
    {
        var result = _service.ConvertTemperature(dto);
        return Ok(result);
    }
}