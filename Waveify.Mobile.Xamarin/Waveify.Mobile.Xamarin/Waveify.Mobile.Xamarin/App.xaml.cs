using System;
using Waveify.Mobile.Xamarin.Services;
using Waveify.Mobile.Xamarin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Waveify.Mobile.Xamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
