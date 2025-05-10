using System.Diagnostics;
using ConversionUnidadesCliWeb_Monster_GR2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using ServiceReference1;

namespace ConversionUnidadesCliWeb_Monster_GR2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Conversor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Convertir(string tipoConversion, double valor)
        {
            double resultado = 0;

            // Crear una instancia del cliente del servicio
            var client = new ConversionUnidadesClient();

            try
            {
                if (tipoConversion == "pulgadasACentimetros")
                {
                    var request = new pulgadasACentimetrosRequest(valor);
                    var response = await client.pulgadasACentimetrosAsync(request);
                    resultado = Math.Round(response.@return, 2); // Redondeo a 2 decimales
                }
                else if (tipoConversion == "centimetrosAPulgadas")
                {
                    var request = new centimetrosAPulgadasRequest(valor);
                    var response = await client.centimetrosAPulgadasAsync(request);
                    resultado = Math.Round(response.@return, 2); // Redondeo a 2 decimales
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                ViewBag.Error = $"Error al llamar al servicio: {ex.Message}";
            }
            finally
            {
                await client.CloseAsync();
            }

            // Pasar el resultado a la vista
            ViewBag.Resultado = resultado;
            ViewBag.TipoConversion = tipoConversion;
            ViewBag.Valor = valor;

            return View("Conversor");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "monster" && password == "gr2_2025")
            {
                // Redirigir al índice si las credenciales son correctas
                return RedirectToAction("Conversor");
            }
            else
            {
                // Mostrar un mensaje de error si las credenciales son incorrectas
                ViewBag.Error = "Usuario o contraseña incorrectos.";
                return View();
            }
        }
    }
}
