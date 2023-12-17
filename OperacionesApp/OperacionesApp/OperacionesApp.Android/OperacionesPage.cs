using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperacionesApp.Droid
{
    public class OperacionesPage : TabbedPage
    {
        public OperacionesPage()
        {
            // Agrega las pestañas a la página de pestañas
            Children.Add(new SumaPage());
            Children.Add(new RestaPage());
            Children.Add(new MultiplicacionPage());
            Children.Add(new DivisionPage());
        }
    }

}