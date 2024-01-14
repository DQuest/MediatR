using MediatR;

namespace WebAppMediatR.Services.WeatherForecast;

public class GetWeatherForecastQuery : IRequest<List<Dtos.WeatherForecastDto>>
{
    public int Count { get; set; }
}