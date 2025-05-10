using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using ConUni_Web_DotNet_G02.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConUni_Web_DotNet_G02.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private const string mainUrl = "http://localhost:9095/Conversion/";

        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("LoggedIn") != "true")
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // Primero valida si están vacíos
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.LoginError = "¡Hey! No te olvides de llenar los campos.";
                return View();
            }

            // Luego valida si las credenciales son correctas
            if (username == "MONSTER" && password == "MONSTER9")
            {
                HttpContext.Session.SetString("LoggedIn", "true");
                return RedirectToAction("Index");
            }

            // Si llega hasta aquí, es porque las credenciales están mal
            ViewBag.LoginError = "¡Uy! Esas credenciales no son";
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Remove("LoggedIn");
            return RedirectToAction("Login");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> ConvertToFahrenheit(string celsius)
        {
            if (HttpContext.Session.GetString("LoggedIn") != "true")
            {
                return RedirectToAction("Login");
            }

            if (!double.TryParse(celsius, NumberStyles.Any, CultureInfo.InvariantCulture, out double celsiusValue))
            {
                ViewBag.FahrenheitResult = "Error: No se pueden convertir letras.";
                return View("Index");
            }

            // Validación para evitar temperaturas menores al cero absoluto
            if (celsiusValue < -273.15)
            {
                ViewBag.FahrenheitResult = "Error: La temperatura no puede ser menor que el cero absoluto (-273.15°C).";
                return View("Index");
            }

            string url = mainUrl + $"CelsiusToFahrenheit/{celsiusValue.ToString(CultureInfo.InvariantCulture)}";

            try
            {
                var result = await client.GetStringAsync(url);
                ViewBag.FahrenheitResult = $"{celsius} Celsius son {result} Fahrenheit.";
            }
            catch (Exception ex)
            {
                ViewBag.FahrenheitResult = "Error: " + ex.Message;
            }
            return View("Index");
        }

        [HttpPost]
        public async Task<ActionResult> ConvertToCelsius(string fahrenheit)
        {
            if (HttpContext.Session.GetString("LoggedIn") != "true")
            {
                return RedirectToAction("Login");
            }

            if (!double.TryParse(fahrenheit, NumberStyles.Any, CultureInfo.InvariantCulture, out double fahrenheitValue))
            {
                ViewBag.CelsiusResult = "Error: No se pueden convertir letras.";
                return View("Index");
            }

            // Validación para evitar temperaturas menores al cero absoluto en Fahrenheit
            if (fahrenheitValue < -459.67) // 0 Kelvin = -459.67 Fahrenheit
            {
                ViewBag.CelsiusResult = "Error: La temperatura no puede ser menor que el cero absoluto (-459.67°F).";
                return View("Index");
            }

            string url = mainUrl + $"FahrenheitToCelsius/{fahrenheitValue.ToString(CultureInfo.InvariantCulture)}";

            try
            {
                var result = await client.GetStringAsync(url);
                ViewBag.CelsiusResult = $"{fahrenheit} Fahrenheit son {result} Celsius.";
            }
            catch (Exception ex)
            {
                ViewBag.CelsiusResult = "Error: " + ex.Message;
            }
            return View("Index");
        }

    }

}

