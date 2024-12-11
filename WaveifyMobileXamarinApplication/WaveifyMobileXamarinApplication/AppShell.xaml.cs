using System;
using System.Collections.Generic;
using WaveifyMobileXamarinApplication.ViewModels;
using WaveifyMobileXamarinApplication.Views;
using Xamarin.Forms;

namespace WaveifyMobileXamarinApplication
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
