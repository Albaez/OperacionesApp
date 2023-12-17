using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using static Android.Telephony.CarrierConfigManager;

namespace OperacionesApp.Droid
{
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App(new OperacionesPage()));
        }
    }
}