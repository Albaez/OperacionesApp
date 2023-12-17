using Android.App;
using Android.Content;
using Android.InputMethodServices;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using static Android.OS.DropBoxManager;

namespace OperacionesApp.Droid
{
    public class MultiplicacionPage : OperacionesPage
    {
        public MultiplicacionPage()
        {
            // Agrega los campos de entrada para los valores a multiplicar
            var valor1 = new Entry { Keyboard = Keyboard.Numeric };
            var valor2 = new Entry { Keyboard = Keyboard.Numeric };

            // Agrega un campo de texto para mostrar el resultado
            var resultado = new Label();

            // Agrega un botón para limpiar todos los campos
            var limpiar = new Button();
            limpiar.Text = "Limpiar";
            limpiar.Clicked += (sender, args) =>
            {
                valor1.Text = "";
                valor2.Text = "";
                resultado.Text = "";
            };

            // Agrega un botón para ejecutar la operación de multiplicación
            var botonMultiplicacion = new Button();
            botonMultiplicacion.Text = "Multiplicar";
            botonMultiplicacion.Clicked += (sender, args) =>
            {
                if (string.IsNullOrEmpty(valor1.Text) || string.IsNullOrEmpty(valor2.Text))
                {
                    resultado.Text = "Por favor ingrese todos los valores.";
                }
                else
                {
                    double v1 = double.Parse(valor1.Text);
                    double v2 = double.Parse(valor2.Text);
                    resultado.Text = $"El resultado de la multiplicación es: {v1 * v2}";
                }
            };

            // Agrega los elementos a la página de multiplicación
            Content = new StackLayout
            {
                Children = {
                new Label { Text = "Ingrese dos valores para multiplicar:" },
                valor1,
                valor2,
                botonMultiplicacion,
                resultado,
                limpiar
            }
            };
        }
    }

}