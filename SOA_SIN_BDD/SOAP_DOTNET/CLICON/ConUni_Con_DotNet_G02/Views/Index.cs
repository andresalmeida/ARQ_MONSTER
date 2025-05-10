//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Globalization;
//using System.Threading;
//using ConUni_Con_DotNet_G02.Controllers;

//namespace ConUni_Con_DotNet_G02.Views
//{
//    internal class Index
//    {
//        private HomeController controller = new HomeController();

//        public void Run()
//        {
//            Console.Clear();
//            Console.WriteLine("Conversión de Temperatura en Consola");
//            while (true)
//            {
//                Console.WriteLine("Seleccione una opción:");
//                Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
//                Console.WriteLine("2. Convertir de Fahrenheit a Celsius");
//                Console.WriteLine("3. Salir");
//                string option = Console.ReadLine();

//                switch (option)
//                {
//                    case "1":
//                        ConvertCelsiusToFahrenheit();
//                        break;
//                    case "2":
//                        ConvertFahrenheitToCelsius();
//                        break;
//                    case "3":
//                        return;
//                    default:
//                        Console.WriteLine("Entrada no válida.");
//                        break;
//                }

//                Thread.Sleep(1000);
//                Console.WriteLine("Presione cualquier tecla para continuar...");
//                Console.ReadKey();
//                Console.Clear();
//            }
//        }

//        private async void ConvertCelsiusToFahrenheit()
//        {
//            Console.WriteLine("Ingresa en Celsius:");
//            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double celsius))
//            {
//                string result = await controller.ConvertToFahrenheitAsync(celsius);
//                Console.WriteLine($"Resultado: {celsius.ToString(CultureInfo.InvariantCulture)} °C es {result} °F");
//            }
//            else
//            {
//                Console.WriteLine("Entrada no válida.");
//            }
//        }

//        private async void ConvertFahrenheitToCelsius()
//        {
//            Console.WriteLine("Ingresa en Fahrenheit:");
//            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double fahrenheit))
//            {
//                string result = await controller.ConvertToCelsiusAsync(fahrenheit);
//                Console.WriteLine($"Resultado: {fahrenheit.ToString(CultureInfo.InvariantCulture)} °F es {result} °C");
//            }
//            else
//            {
//                Console.WriteLine("Entrada no válida.");
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using ConUni_Con_DotNet_G02.Controllers;

namespace ConUni_Con_DotNet_G02.Views
{
    internal class Index
    {
        // Definición de colores
        private const string Celeste = "\u001b[38;5;51m";
        private const string Verde = "\u001b[38;5;46m";
        private const string Amarillo = "\u001b[38;5;226m";
        private const string Naranja = "\u001b[38;5;208m";
        private const string Rojo = "\u001b[31m";
        private const string Reset = "\u001b[0m";
        private const string Negrita = "\u001b[1m";

        private HomeController controller = new HomeController();

        public void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                MostrarEncabezado();
                MostrarMenu();

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ConvertCelsiusToFahrenheit();
                        break;
                    case "2":
                        ConvertFahrenheitToCelsius();
                        break;
                    case "3":
                        MostrarMensajeDespedida();
                        return;
                    default:
                        MostrarError("Opción no válida. Por favor, elija una opción del menú.");
                        break;
                }

                Console.WriteLine($"\n{Amarillo}Presione cualquier tecla para continuar...{Reset}");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void MostrarEncabezado()
        {
            Console.Clear();
            Console.WriteLine($@"
{Celeste}████████╗███████╗███╗   ███╗██████╗ ███████╗██████╗  █████╗ ████████╗██╗   ██╗██████╗  █████╗ {Reset}
{Celeste}╚══██╔══╝██╔════╝████╗ ████║██╔══██╗██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██║   ██║██╔══██╗██╔══██╗{Reset}
{Celeste}   ██║   █████╗  ██╔████╔██║██████╔╝█████╗  ██████╔╝███████║   ██║   ██║   ██║██████╔╝███████║{Reset}
{Celeste}   ██║   ██╔══╝  ██║╚██╔╝██║██╔═══╝ ██╔══╝  ██╔══██╗██╔══██║   ██║   ██║   ██║██╔══██╗██╔══██║{Reset}
{Celeste}   ██║   ███████╗██║ ╚═╝ ██║██║     ███████╗██║  ██║██║  ██║   ██║   ╚██████╔╝██║  ██║██║  ██║{Reset}
{Celeste}   ╚═╝   ╚══════╝╚═╝     ╚═╝╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝{Reset}
");
            Console.WriteLine($"{Verde}{Negrita}╔══════════════════════════════════════════════════════════════════════════════╗{Reset}");
            Console.WriteLine($"{Verde}{Negrita}║                      SISTEMA DE CONVERSIÓN DE TEMPERATURA                     ║{Reset}");
            Console.WriteLine($"{Verde}{Negrita}╚══════════════════════════════════════════════════════════════════════════════╝{Reset}");
            Console.WriteLine();
        }

        private void MostrarMenu()
        {
            Console.WriteLine($"{Celeste}╔══════════════════════════════════════════════════════════════════════════════╗{Reset}");
            Console.WriteLine($"{Celeste}║                              MENÚ PRINCIPAL                                  ║{Reset}");
            Console.WriteLine($"{Celeste}╠══════════════════════════════════════════════════════════════════════════════╣{Reset}");
            Console.WriteLine($"{Celeste}║{Reset}  {Verde}[1]{Reset} Convertir de {Amarillo}Celsius{Reset} a {Naranja}Fahrenheit{Reset}                                        {Celeste}║{Reset}");
            Console.WriteLine($"{Celeste}║{Reset}  {Verde}[2]{Reset} Convertir de {Naranja}Fahrenheit{Reset} a {Amarillo}Celsius{Reset}                                        {Celeste}║{Reset}");
            Console.WriteLine($"{Celeste}║{Reset}  {Rojo}[3]{Reset} Salir                                                                   {Celeste}║{Reset}");
            Console.WriteLine($"{Celeste}╚══════════════════════════════════════════════════════════════════════════════╝{Reset}");
            Console.WriteLine();
            Console.Write($"{Verde}Seleccione una opción: {Reset}");
        }

        private void MostrarError(string mensaje)
        {
            Console.WriteLine($"\n{Rojo}ERROR: {mensaje}{Reset}");
            Thread.Sleep(1500);
        }

        private void MostrarMensajeDespedida()
        {
            Console.Clear();
            Console.WriteLine($@"
{Verde}╔══════════════════════════════════════════════════════════════════════════════╗{Reset}
{Verde}║                             HASTA PRONTO                                      ║{Reset}
{Verde}╚══════════════════════════════════════════════════════════════════════════════╝{Reset}
");
            Console.WriteLine($"{Celeste}Gracias por utilizar el sistema Monster de conversión de temperatura.{Reset}");
            Console.WriteLine($"{Amarillo}¡Que tenga un excelente día!{Reset}");
            Thread.Sleep(2000);
        }

        private async void ConvertCelsiusToFahrenheit()
        {
            Console.WriteLine();
            Console.WriteLine($"{Verde}╔══════════════════════════════════════════════════════════════════════════════╗{Reset}");
            Console.WriteLine($"{Verde}║                     CONVERSIÓN DE CELSIUS A FAHRENHEIT                       ║{Reset}");
            Console.WriteLine($"{Verde}╚══════════════════════════════════════════════════════════════════════════════╝{Reset}");
            Console.WriteLine();
            Console.Write($"{Amarillo}Ingrese la temperatura en Celsius: {Reset}");

            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double celsius))
            {
                Console.WriteLine($"\n{Celeste}Calculando...{Reset}");
                // Pequeña animación para mostrar que está procesando
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{Celeste}.{Reset}");
                    Thread.Sleep(200);
                }
                Console.WriteLine();

                string result = await controller.ConvertToFahrenheitAsync(celsius);

                Console.WriteLine($"\n{Verde}╔══════════════════════════════════════════════════════════════════════════════╗{Reset}");
                Console.WriteLine($"{Verde}║                             RESULTADO                                        ║{Reset}");
                Console.WriteLine($"{Verde}╚══════════════════════════════════════════════════════════════════════════════╝{Reset}");
                Console.WriteLine();
                Console.WriteLine($"  {Amarillo}{celsius.ToString(CultureInfo.InvariantCulture)} °C{Reset} equivale a {Naranja}{result} °F{Reset}");
                Console.WriteLine();
            }
            else
            {
                MostrarError("Entrada no válida. Por favor, ingrese un número.");
            }
        }

        private async void ConvertFahrenheitToCelsius()
        {
            Console.WriteLine();
            Console.WriteLine($"{Verde}╔══════════════════════════════════════════════════════════════════════════════╗{Reset}");
            Console.WriteLine($"{Verde}║                     CONVERSIÓN DE FAHRENHEIT A CELSIUS                       ║{Reset}");
            Console.WriteLine($"{Verde}╚══════════════════════════════════════════════════════════════════════════════╝{Reset}");
            Console.WriteLine();
            Console.Write($"{Naranja}Ingrese la temperatura en Fahrenheit: {Reset}");

            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double fahrenheit))
            {
                Console.WriteLine($"\n{Celeste}Calculando...{Reset}");
                // Pequeña animación para mostrar que está procesando
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{Celeste}.{Reset}");
                    Thread.Sleep(200);
                }
                Console.WriteLine();

                string result = await controller.ConvertToCelsiusAsync(fahrenheit);

                Console.WriteLine($"\n{Verde}╔══════════════════════════════════════════════════════════════════════════════╗{Reset}");
                Console.WriteLine($"{Verde}║                             RESULTADO                                        ║{Reset}");
                Console.WriteLine($"{Verde}╚══════════════════════════════════════════════════════════════════════════════╝{Reset}");
                Console.WriteLine();
                Console.WriteLine($"  {Naranja}{fahrenheit.ToString(CultureInfo.InvariantCulture)} °F{Reset} equivale a {Amarillo}{result} °C{Reset}");
                Console.WriteLine();
            }
            else
            {
                MostrarError("Entrada no válida. Por favor, ingrese un número.");
            }
        }
    }
}