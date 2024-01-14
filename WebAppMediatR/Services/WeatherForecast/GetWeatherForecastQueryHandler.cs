using MediatR;

namespace WebAppMediatR.Services.WeatherForecast;

public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQuery, List<Dtos.WeatherForecastDto>>
{
    private readonly string[] _summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    public async Task<List<Dtos.WeatherForecastDto>> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
    {
        var forecast = Enumerable.Range(1, request.Count).Select(index =>
                new Dtos.WeatherForecastDto
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = _summaries[Random.Shared.Next(_summaries.Length)]
                })
            .ToList();

        return forecast;
    }
}