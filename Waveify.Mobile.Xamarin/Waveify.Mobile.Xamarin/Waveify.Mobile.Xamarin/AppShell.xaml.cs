using System;
using System.Collections.Generic;
using Waveify.Mobile.Xamarin.ViewModels;
using Waveify.Mobile.Xamarin.Views;
using Xamarin.Forms;

namespace Waveify.Mobile.Xamarin
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
