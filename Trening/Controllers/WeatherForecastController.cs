using Microsoft.AspNetCore.Mvc;

namespace Trening.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
<<<<<<< HEAD
<<<<<<< HEAD
        "Freezing", "Bracing", "Chilly","Dawid", "Cool", "Mild", "Warm", "Balmy", "Hottsdser", "Sweltering", "Scorching","Cold","More Cold2"
=======
        "Freezing", "Bracing","Dawid", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hotter", "Sweltering", "Scorching","Cold","More Cold"
>>>>>>> fix
=======
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hottsdser", "Sweltering", "Scorching","Cold","More Cold2"
>>>>>>> parent of 3de99de (Dodanie do listy)
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}