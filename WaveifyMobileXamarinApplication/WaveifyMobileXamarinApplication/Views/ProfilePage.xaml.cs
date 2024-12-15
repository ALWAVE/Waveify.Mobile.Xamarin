using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveifyMobileXamarinApplication.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaveifyMobileXamarinApplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            this.BindingContext = new ProfileViewModel();
        }

        private async void OnChangeButtonClicked(object sender, EventArgs e)
        {
            // URL, на который нужно перейти
            string url = "https://www.example.com"; // Замените на нужный вам URL

            // Открыть URL в браузере
            await Launcher.OpenAsync(new Uri(url));
        }
    }
}