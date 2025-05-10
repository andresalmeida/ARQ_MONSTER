//using System;
//using System.Web;
//using ConUni_Con_DotNet_G02.Views;

//namespace ConUni_Con_DotNet_G02.Controllers
//{
//    internal class LoginController
//    {
//        private LoginView view = new LoginView();

//        public bool Login()
//        {
//            var (user, pass) = view.PromptLogin();

//            // Aquí podrías hacer una consulta a un servicio externo o una DB, por ahora hardcode
//            return user == "MONSTER" && pass == "MONSTER9";
//        }
//    }
//}

using System;
using ConUni_Con_DotNet_G02.Views;

namespace ConUni_Con_DotNet_G02.Controllers
{
    internal class LoginController
    {
        private LoginView _loginView;

        public LoginController()
        {
            _loginView = new LoginView();
        }

        public bool Login()
        {
            bool loginExitoso = false;
            bool seguirIntentando = true;

            while (!loginExitoso && seguirIntentando)
            {
                // Obtener credenciales del usuario
                var (usuario, password) = _loginView.PromptLogin();

                // Validar las credenciales (aquí deberías poner tu lógica de validación real)
                if (ValidarCredenciales(usuario, password))
                {
                    loginExitoso = true;
                }
                else
                {
                    // Si las credenciales son incorrectas, preguntar si quiere intentar nuevamente
                    seguirIntentando = _loginView.MostrarErrorCredenciales();
                }
            }

            return loginExitoso;
        }

        private bool ValidarCredenciales(string usuario, string password)
        {
            // Aquí coloca tu lógica de validación real
            // Por ejemplo, comprobar en una base de datos, archivo, etc.

            // Este es solo un ejemplo, reemplázalo con tu validación real
            return (usuario == "MONSTER" && password == "MONSTER9");
        }
    }
}