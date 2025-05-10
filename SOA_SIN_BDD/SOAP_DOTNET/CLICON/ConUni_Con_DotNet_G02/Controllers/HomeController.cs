using System;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using System.Globalization;  // Importante para utilizar CultureInfo

namespace ConUni_Con_DotNet_G02.Controllers
{
    internal class HomeController
    {
        private static readonly HttpClient client = new HttpClient();
        private const string mainUrl = "http://localhost:9095/Conversion/";

        // Validación de cero absoluto en Celsius (-273.15°C)
        public async Task<string> ConvertToFahrenheitAsync(double celsius)
        {
            if (celsius < -273.15)
            {
                return "Error: La temperatura en Celsius no puede ser menor al cero absoluto (-273.15°C).";
            }

            string url = mainUrl + $"CelsiusToFahrenheit/{celsius.ToString(CultureInfo.InvariantCulture)}";
            try
            {
                return await client.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // Validación de cero absoluto en Fahrenheit (-459.67°F)
        public async Task<string> ConvertToCelsiusAsync(double fahrenheit)
        {
            if (fahrenheit < -459.67)
            {
                return "Error: La temperatura en Fahrenheit no puede ser menor al cero absoluto (-459.67°F).";
            }

            string url = mainUrl + $"FahrenheitToCelsius/{fahrenheit.ToString(CultureInfo.InvariantCulture)}";
            try
            {
                return await client.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}
