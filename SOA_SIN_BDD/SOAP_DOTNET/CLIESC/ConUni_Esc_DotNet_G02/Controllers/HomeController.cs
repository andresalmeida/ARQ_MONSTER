using System;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using System.Globalization;

namespace ConUni_Esc_DotNet_G02.Controllers
{
    public class HomeController
    {
        private static readonly HttpClient client = new HttpClient();
        private const string mainUrl = "http://localhost:9095/Conversion/";

        public bool ValidateLogin(string username, string password)
        {
            return username == "MONSTER" && password == "MONSTER9";
        }

        public async Task<string> ConvertToFahrenheitAsync(double celsius)
        {
            if (celsius < -273.15)
            {
                return "Error: No menor a (-273.15 °C)";
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

        public async Task<string> ConvertToCelsiusAsync(double fahrenheit)
        {
            if (fahrenheit < -459.67)
            {
                return "Error: No menor a (-459.67 °F)";
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
