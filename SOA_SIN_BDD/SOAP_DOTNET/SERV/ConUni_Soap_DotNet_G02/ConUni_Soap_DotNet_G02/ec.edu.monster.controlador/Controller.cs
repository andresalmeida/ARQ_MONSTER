using ConUni_Soap_DotNet_G02.ec.edu.monster.modelo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConUni_Soap_DotNet_G02.ec.edu.monster.controlador
{
    [ApiController]
    [Route("[controller]")]
    public class ConversionController : ControllerBase
    {
        private readonly ILogger<ConversionController> _logger;
        private readonly Conversión _conversor;  // Instancia de la clase de conversión

        public ConversionController(ILogger<ConversionController> logger, Conversión conversor)
        {
            _logger = logger;
            _conversor = conversor;  // Inyecta la dependencia del conversor
        }

     [HttpGet("CelsiusToFahrenheit/{celsius}")]
        public ActionResult<double> CelsiusToFahrenheit(double celsius)
        {
            try
            {
                double result = _conversor.CelsiusToFahrenheit(celsius);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error converting Celsius to Fahrenheit");
                return BadRequest("Conversion error occurred");
            }
        }

        [HttpGet("FahrenheitToCelsius/{fahrenheit}")]
        public ActionResult<double> FahrenheitToCelsius(double fahrenheit)
        {
            try
            {
                double result = _conversor.FahrenheitToCelsius(fahrenheit);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error converting Fahrenheit to Celsius");
                return BadRequest("Conversion error occurred");
            }
        }
    }
}
