using Microsoft.AspNetCore.Mvc;

namespace Trening.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Dawid","Agata","Bartek","£ukasz","Agusia","Kasia"
        };
        
        private static readonly string[] Summaries2 = new[]
        {
            "Mama","Tata","Dziadek"
        };
        
        private static readonly string[] Summaries3 = new[]
        {
            "Żona","Dzieci","Dzdiadkowie"
        };

        private static readonly string[] Summaries4 = new[]
        {
            "Żona","Dzieci","Dzdiadkowie","Wujki"
        };

        private static readonly string[] Summaries5 = new[]
        {
            "Żona","Dzieci","Dzdiadkowie"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            Console.WriteLine("Bartek");
            //Added by other user meanwhile
            Console.WriteLine("Dawid and Agata");

            //Added by another user meanwhile
            Console.WriteLine("Dawid and Agata big love");

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
