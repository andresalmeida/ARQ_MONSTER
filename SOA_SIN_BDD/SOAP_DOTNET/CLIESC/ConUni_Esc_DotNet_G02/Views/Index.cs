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

namespace ConUni_Esc_DotNet_G02.Views
{
    public partial class Index : Form
    {
        private HomeController controller;

        public Index(HomeController controller)
        {
            this.controller = controller;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void btnConvertToFahrenheit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                var result = await controller.ConvertToFahrenheitAsync(celsius);
                lblFahrenheitResult.Text = $"Resultado en °F: {result}";
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido para Celsius.");
            }
        }

        private async void btnConvertToCelsius_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtFahrenheit.Text, out double fahrenheit))
            {
                var result = await controller.ConvertToCelsiusAsync(fahrenheit);
                lblCelsiusResult.Text = $"Resultado en °C: {result}";
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido para Fahrenheit.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Cerrar sesión
            MessageBox.Show("Has cerrado sesión");
            this.Hide();
            new Login().Show();
        }
    }
}
