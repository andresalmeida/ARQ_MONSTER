//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConUni_Con_DotNet_G02.Views
//{
//    internal class LoginView
//    {
//        public (string, string) PromptLogin()
//        {
//            Console.Clear();
//            Console.OutputEncoding = Encoding.UTF8; // Por si usás caracteres especiales
//            Console.WriteLine("=== BIENVENIDO A CONVERSIÓN DE UNIDADES ===");
//            Console.Write("Usuario: ");
//            string user = Console.ReadLine();
//            Console.Write("Contraseña: ");
//            string pass = ReadPassword();
//            return (user, pass);
//        }
//        private string ReadPassword()
//        {
//            StringBuilder password = new StringBuilder();
//            ConsoleKeyInfo key;

//            do
//            {
//                key = Console.ReadKey(intercept: true);

//                if (key.Key == ConsoleKey.Backspace && password.Length > 0)
//                {
//                    password.Remove(password.Length - 1, 1);
//                    Console.Write("\b \b"); // Elimina el último *
//                }
//                else if (!char.IsControl(key.KeyChar))
//                {
//                    password.Append(key.KeyChar);
//                    Console.Write("*");
//                }
//            }
//            while (key.Key != ConsoleKey.Enter);

//            Console.WriteLine(); // Bajamos de línea al terminar
//            return password.ToString();
//        }
//    }
//}

//using System;
//using System.Text;

//namespace ConUni_Con_DotNet_G02.Views
//{
//    internal class LoginView
//    {
//        private const string Celeste = "\u001b[38;5;51m";
//        private const string Reset = "\u001b[0m";

//        public (string, string) PromptLogin()
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            LimpiarPantalla();
//            MostrarLogo();
//            MostrarImagen();

//            Console.Write($"{Celeste}Usuario:{Reset} ");
//            string user = Console.ReadLine();

//            Console.Write($"{Celeste}Contraseña:{Reset} ");
//            string pass = LeerContraseña();

//            return (user, pass);
//        }

//        private string LeerContraseña()
//        {
//            var pass = new StringBuilder();
//            ConsoleKeyInfo key;

//            do
//            {
//                key = Console.ReadKey(true);

//                if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
//                {
//                    pass.Remove(pass.Length - 1, 1);
//                    Console.Write("\b \b");
//                }
//                else if (!char.IsControl(key.KeyChar))
//                {
//                    pass.Append(key.KeyChar);
//                    Console.Write("*");
//                }
//            } while (key.Key != ConsoleKey.Enter);

//            Console.WriteLine(); // Salto de línea al final
//            return pass.ToString();
//        }

//        private void LimpiarPantalla()
//        {
//            Console.Clear();
//        }

//        private void MostrarLogo()
//        {
//            Console.WriteLine($@"
//{Celeste}███╗   ███╗ ██████╗ ███╗   ██╗███████╗████████╗███████╗██████╗     ██████╗ ██████╗  ██████████{Reset}
//{Celeste}████╗ ████║██╔═══██╗████╗  ██║██╔════╝╚══██╔══╝██╔════╝██╔══██╗   ██╔════╝ ██╔══██╗ ╚═██  ██═╝{Reset}
//{Celeste}██╔████╔██║██║   ██║██╔██╗ ██║███████╗   ██║   █████╗  ██████╔╝   ██║  ███╗██████╔╝   ██  ██ {Reset}
//{Celeste}██║╚██╔╝██║██║   ██║██║╚██╗██║╚════██║   ██║   ██╔══╝  ██╔══██╗   ██║   ██║██╔══██╗   ██  ██ {Reset}
//{Celeste}██║ ╚═╝ ██║╚██████╔╝██║ ╚████║███████║   ██║   ███████╗██║  ██║   ╚██████╔╝██║  ██║ ██████████ {Reset}
//{Celeste}╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝    ╚═════╝ ╚═╝  ╚═╝ ╚════════╝{Reset}
//");
//        }

//        private void MostrarImagen()
//        {
//            Console.WriteLine($"{Celeste}MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMMMMWNXXXWMMMMMMMMMMMMMMMMMMMMMMNXXNWWMMMMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMMX0O0Ox0WMMMMMMMMWNXK0XMMMMMMMMXkxO00XWMMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMW0dx0KOKWMMMWX000Okxdolk0O0NMMMMMNOxO0kONMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMM0clxOkkKNN0kdlclodddddooollxOOkOKXkldkkdkNMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMWd,;lodddoc:;:cloooddddooooooolllollodddoo0MMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMWO;.',;;;,;::::::ccodddoc:::::ccllllllcc:dXMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMWOc.....';;,,,,,,;cddo:,,,,;;;;:::;,',cxXMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMMNO:........','',cddoc;,',,'.',,;:;;dKWMMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMMXx;',',,:odlccc:coddocccclddl;;:looxKWMMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMNx,.,;;;:kXd'..ldooddoll'..cOXdldddlcoKWMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMXx;';;;;:xKk:',ldoooooooc',l0Kxodddoco0WMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMNOc,,;:ccccoxxddolcccccclddxkkdodddddolkXWMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMWXd,',;;coddolllc;,',;;;;;;;cloooddddddddccONMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMNx;,;;;:ldddddddo;'.',,,;;,;cdddddddddddxdcl0WM{Reset}");
//            Console.WriteLine($"{Celeste}MMMXl,,;;;codddddddddolc:::coddddddddddddddddockWM{Reset}");
//            Console.WriteLine($"{Celeste}MMWOc,;;;;cllloddddddddddddddddddddddolodddddddxXM{Reset}");
//            Console.WriteLine($"{Celeste}MMXo,,,;;;:loolokxdddddddddddddddodkdloddddddllo0W{Reset}");
//            Console.WriteLine($"{Celeste}MMXl'',,;;:ldddodolooloooooooooolloddddddddddl;cOW{Reset}");
//            Console.WriteLine($"{Celeste}MMNx:,;;;;;coddddoolllllooollloooddxdddddodddocl0M{Reset}");
//            Console.WriteLine($"{Celeste}MMMXo;;,,,;:codddddolllllllloooodddddddddoddoooOWM{Reset}");
//            Console.WriteLine($"{Celeste}MMMNd,',;;;;:lddddddddddddddddddddddddddddddlco0MM{Reset}");
//            Console.WriteLine($"{Celeste}MMMWO:,,;;;;;:cldddddddddddddddddddddddddddoc:dXMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMNKkc,',;;;;:clolcldddddddddooooollllool:dOXWMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMW0l;;,,,,;;;:;;:ccclllccc:::::;;::::lxXMMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMMMWXOl;,',,,,,;;;;;;;;;;;;,,,;,',:lkXWMMMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMMMMMMWKxllxd:;::;;;;;,,,::;:dOkoxKWMMMMMMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMMMMMMMMMNNWWNKXKkl;;:ldOKXKNWMWWMMMMMMMMMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMMMMMMMMMMMMMMMMMMN00KWMMMMMMMMMMMMMMMMMMMMMM{Reset}");
//            Console.WriteLine($"{Celeste}MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM{Reset}");
//        }
//    }
//}


using System;
using System.Text;

namespace ConUni_Con_DotNet_G02.Views
{
    internal class LoginView
    {
        private const string Celeste = "\u001b[38;5;51m";
        private const string Red = "\u001b[31m";
        private const string Reset = "\u001b[0m";

        public (string, string) PromptLogin()
        {
            string user = string.Empty;
            string pass = string.Empty;
            bool loginSuccessful = false;

            while (!loginSuccessful)
            {
                Console.OutputEncoding = Encoding.UTF8;
                LimpiarPantalla();
                MostrarLogo();
                MostrarImagen();

                Console.Write($"{Celeste}Usuario:{Reset} ");
                user = Console.ReadLine();

                Console.Write($"{Celeste}Contraseña:{Reset} ");
                pass = LeerContraseña();

                // Aquí deberías validar las credenciales con tu sistema de autenticación
                // Por ahora, solo devolvemos las credenciales y se supone que otra parte del código
                // va a verificar si son correctas o no.

                // Si llegamos aquí, salimos del bucle para devolver las credenciales
                // que serán validadas en otro lugar del código
                return (user, pass);
            }

            return (user, pass); // Nunca llegará aquí, pero es necesario para compilar
        }

        // Este método puede ser llamado desde fuera para mostrar error e intentar nuevamente
        public bool MostrarErrorCredenciales()
        {
            Console.WriteLine($"\n{Red}¡Uy! Esas no son las credenciales. Por favor, intente nuevamente.{Reset}");
            Console.WriteLine($"{Celeste}Presione ENTER para intentar nuevamente o ESC para salir.{Reset}");

            ConsoleKeyInfo key = Console.ReadKey(true);
            return (key.Key != ConsoleKey.Escape); // Retorna true si el usuario quiere intentar de nuevo
        }

        private string LeerContraseña()
        {
            var pass = new StringBuilder();
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    pass.Remove(pass.Length - 1, 1);
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    pass.Append(key.KeyChar);
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine(); // Salto de línea al final
            return pass.ToString();
        }

        private void LimpiarPantalla()
        {
            Console.Clear();
        }

        private void MostrarLogo()
        {
            Console.WriteLine($@"
    {Celeste}███╗   ███╗ ██████╗ ███╗   ██╗███████╗████████╗███████╗██████╗     ██████╗ ██████╗  ██████████{Reset}
    {Celeste}████╗ ████║██╔═══██╗████╗  ██║██╔════╝╚══██╔══╝██╔════╝██╔══██╗   ██╔════╝ ██╔══██╗ ╚═██  ██═╝{Reset}
    {Celeste}██╔████╔██║██║   ██║██╔██╗ ██║███████╗   ██║   █████╗  ██████╔╝   ██║  ███╗██████╔╝   ██  ██ {Reset}
    {Celeste}██║╚██╔╝██║██║   ██║██║╚██╗██║╚════██║   ██║   ██╔══╝  ██╔══██╗   ██║   ██║██╔══██╗   ██  ██ {Reset}
    {Celeste}██║ ╚═╝ ██║╚██████╔╝██║ ╚████║███████║   ██║   ███████╗██║  ██║   ╚██████╔╝██║  ██║ ██████████ {Reset}
    {Celeste}╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝    ╚═════╝ ╚═╝  ╚═╝ ╚════════╝{Reset}
");
        }

        private void MostrarImagen()
        {
            Console.WriteLine($"{Celeste}MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMMWNXXXWMMMMMMMMMMMMMMMMMMMMMMMMNXXNWWMMMMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMMX0O0Ox0WMMMMMMMMWNXK0XMMMMMMMMXkxO00XWMMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMW0dx0KOKWMMMWX000Okxdolk0O0NMMMMMNOxO0kONMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMM0clxOkkKNN0kdlclodddddooollxOOkOKXkldkkdkNMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMWd,;lodddoc:;:cloooddddooooooolllollodddoo0MMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMWO;.',;;;,;::::::ccodddoc:::::ccllllllcc:dXMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMWOc.....';;,,,,,,;cddo:,,,,;;;;:::;,',cxXMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMMNO:........','',cddoc;,',,'.',,;:;;dKWMMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMMXx;',',,:odlccc:coddocccclddl;;:looxKWMMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMNx,.,;;;:kXd'..ldooddoll'..cOXdldddlcoKWMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMXx;';;;;:xKk:',ldoooooooc',l0Kxodddoco0WMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMNOc,,;:ccccoxxddolcccccclddxkkdodddddolkXWMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMWXd,',;;coddolllc;,',;;;;;;;cloooddddddddccONMM{Reset}");
            Console.WriteLine($"{Celeste}MMMNx;,;;;:ldddddddo;'.',,,;;,;cdddddddddddxdcl0WM{Reset}");
            Console.WriteLine($"{Celeste}MMMXl,,;;;codddddddddolc:::coddddddddddddddddockWM{Reset}");
            Console.WriteLine($"{Celeste}MMWOc,;;;;cllloddddddddddddddddddddddolodddddddxXM{Reset}");
            Console.WriteLine($"{Celeste}MMXo,,,;;;:loolokxdddddddddddddddodkdloddddddllo0W{Reset}");
            Console.WriteLine($"{Celeste}MMXl'',,;;:ldddodolooloooooooooolloddddddddddl;cOW{Reset}");
            Console.WriteLine($"{Celeste}MMNx:,;;;;;coddddoolllllooollloooddxdddddodddocl0M{Reset}");
            Console.WriteLine($"{Celeste}MMMXo;;,,,;:codddddolllllllloooodddddddddoddoooOWM{Reset}");
            Console.WriteLine($"{Celeste}MMMNd,',;;;;:lddddddddddddddddddddddddddddddlco0MM{Reset}");
            Console.WriteLine($"{Celeste}MMMWO:,,;;;;;:cldddddddddddddddddddddddddddoc:dXMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMNKkc,',;;;;:clolcldddddddddooooollllool:dOXWMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMW0l;;,,,,;;;:;;:ccclllccc:::::;;::::lxXMMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMMMWXOl;,',,,,,;;;;;;;;;;;;,,,;,',:lkXWMMMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMMMMMMWKxllxd:;::;;;;;,,,::;:dOkoxKWMMMMMMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMMMMMMMMMNNWWNKXKkl;;:ldOKXKNWMWWMMMMMMMMMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMMMMMMMMMMMMMMMMMMN00KWMMMMMMMMMMMMMMMMMMMMMM{Reset}");
            Console.WriteLine($"{Celeste}MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM{Reset}");
        }
    }
}
