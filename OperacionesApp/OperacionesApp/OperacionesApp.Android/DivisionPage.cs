using Android.InputMethodServices;
using Android.Widget;
using System.Reflection.Emit;
using static Android.OS.DropBoxManager;

namespace OperacionesApp.Droid
{
    public class DivisionPage : OperacionesPage
    {
        public DivisionPage()
        {
            // Agrega los campos de entrada para los valores a dividir
            var valor1 = new Entry { Keyboard = Keyboard.Numeric };
            var valor2 = new Entry { Keyboard = Keyboard.Numeric };

            // Agrega un campo de texto para mostrar el resultado
            var resultado = new Label();

            // Agrega un botón para limpiar todos los campos
            var limpiar = new Button();
            limpiar.Text = "Limpiar";
            limpiar.Click += (sender, args) =>
            {
                valor1.Text = "";
                valor2.Text = "";
                resultado.Text = "";
            };

            // Agrega un botón para ejecutar la operación de división
            var botonDivision = new Button();
            botonDivision.Text = "Dividir";
            botonDivision.Click += (sender, args) =>
            {
                if (string.IsNullOrEmpty(valor1.Text) || string.IsNullOrEmpty(valor2.Text))
                {
                    resultado.Text = "Por favor ingrese todos los valores.";
                }
                else if (valor2.Text == "0")

            };
        }
    }
}