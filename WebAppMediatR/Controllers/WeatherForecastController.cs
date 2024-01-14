using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAppMediatR.Services.WeatherForecast;

namespace WebAppMediatR.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IMediator _mediator;

    public WeatherForecastController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult> GetForecast([FromQuery] int count)
    {
        var result = await _mediator.Send(new GetWeatherForecastQuery { Count = count });
        return Ok(result);
    }
}