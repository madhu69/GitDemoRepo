using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OnePayScedularAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OnePayScedulController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching",
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching",
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching",
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching",
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] Summaries 2 = new[]
        {
            "one", "two", "chree", "four", "five", "six", "seven", "enight", "nine", "ten",
            
        };

        private static readonly string[] Summaries 3 = new[]
        {
            "A", "b", "c", "d", "e", "f", "g", "h", "i", "j",
            
        };


        private static readonly string[] Summaries 4 = new[]
        {
            "A", "b", "c", "d", "e", "f", "g", "h", "i", "j",

        };


private readonly ILogger<OnePayScedulController> _logger;

        public OnePayScedulController(ILogger<OnePayScedulController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
