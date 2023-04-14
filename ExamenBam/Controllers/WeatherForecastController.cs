using BAM.DOMAIN.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamenBam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult<Marca> Get()
        {
            var rng = new Random();

            Marca obj = new Marca
            {

                MarcaId = Guid.NewGuid(),
                Descripcion = "ALGO",
                Vehiculos = null


            };


            return Ok(obj);
        }
    }
}