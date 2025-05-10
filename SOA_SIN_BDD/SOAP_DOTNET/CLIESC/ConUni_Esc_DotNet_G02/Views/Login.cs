using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConUni_Esc_DotNet_G02.Controllers;
using ConUni_Esc_DotNet_G02.Views;

namespace ConUni_Esc_DotNet_G02.Views
{
    public partial class Login : Form
    {
        private HomeController controller = new HomeController();

        public Login()
        {
            InitializeComponent(GetPanelLogin());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (controller.ValidateLogin(username, password))
            {
                MessageBox.Show("¡Bienvenido al Sistema Monster!");
                new Index(controller).Show();  // Pasamos el controlador al formulario Index
                this.Hide();
            }
            else
            {
                MessageBox.Show("¡Uy! Esas credenciales no son.");
            }
        }


    }
}

