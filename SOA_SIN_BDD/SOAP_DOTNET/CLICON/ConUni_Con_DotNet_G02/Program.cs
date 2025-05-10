//using System;
//using ConUni_Con_DotNet_G02.Controllers;
//using ConUni_Con_DotNet_G02.Views;
//using Index = ConUni_Con_DotNet_G02.Views.Index;


//namespace ConUni_Con_DotNet_G02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var loginController = new LoginController();

//            if (loginController.Login())
//            {
//                var index = new Index(); // Tu vista principal
//                index.Run(); // Muestra el menú
//            }
//            else
//            {
//                Console.WriteLine("Credenciales inválidas. Saliendo...");
//            }
//        }
//    }
//}

using System;
using ConUni_Con_DotNet_G02.Controllers;
using ConUni_Con_DotNet_G02.Views;
using Index = ConUni_Con_DotNet_G02.Views.Index;

namespace ConUni_Con_DotNet_G02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loginController = new LoginController();

            if (loginController.Login())
            {
                var index = new Index(); // Tu vista principal
                index.Run(); // Muestra el menú
            }
            else
            {
                // Este mensaje solo se mostrará si el usuario decide salir (presionando ESC)
                Console.WriteLine("Programa finalizado.");
            }
        }
    }
}