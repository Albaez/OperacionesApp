﻿using System;
using System.Collections.Generic;
using OperacionesApp.ViewModels;
using OperacionesApp.Views;
using Xamarin.Forms;

namespace OperacionesApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
