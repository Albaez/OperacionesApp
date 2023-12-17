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
    public class SumaPage : OperacionesPage
    {
        public SumaPage()
        {
            // Agrega los campos de entrada para los valores a sumar
            Entry valor1 = new Entry { Keyboard = Keyboard.Numeric };
            Entry valor2 = new Entry { Keyboard = Keyboard.Numeric };

            // Agrega un campo de texto para mostrar el resultado
            Label resultado = new Label();

            // Agrega un botón para limpiar todos los campos
            Button limpiar = new Button
            {
                Text = "Limpiar"
            };
            limpiar.Click += (sender, args) =>
            {
                valor1.GetText = "";
                valor2.GetText = "";
                resultado.GetText = "";
            };

            // Agrega un botón para ejecutar la operación de suma
            Button botonSuma = new Button();
            botonSuma.Text = "Sumar";
            botonSuma.Click += (sender, args) =>
            {
                if (string.IsNullOrEmpty(valor1.GetText) || string.IsNullOrEmpty(valor2.GetText))
                {
                    resultado.Text = "Por favor ingrese todos los valores.";
                }
                else
                {
                    double v1 = double.Parse(valor1.GetText);
                    double v2 = double.Parse(valor2.GetText);
                    resultado.GetText = $"El resultado de la suma es: {v1 + v2}";
                }
            };

            // Agrega los elementos a la página de suma
            Content = new StackLayout
            {
                Children = {
                new Label { GetText = "Ingrese dos valores para sumar:" },
                valor1,
                valor2,
                botonSuma,
                resultado,
                limpiar
            }
            };
        }
    }



}