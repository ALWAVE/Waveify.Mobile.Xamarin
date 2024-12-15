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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        private async void OnButtonClickedSignInLink(object sender, EventArgs e)
        {
            var button = sender as Button;

            // Увеличиваем размер кнопки
            await button.ScaleTo(1.1, 50); // Увеличение до 120% за 100 мс
            await button.ScaleTo(1.0, 50);
            // URL, на который нужно перейти
            string url = "https://www.example.com"; // Замените на нужный вам URL

            // Открыть URL в браузере
            await Launcher.OpenAsync(new Uri(url));
        }
        private async void OnLoginClicked(object obj)
        {
          

            var button = obj as Button;

            // Увеличиваем размер кнопки
            await button.ScaleTo(1.1, 50); // Увеличение до 120% за 100 мс
            await button.ScaleTo(1.0, 50);
            // URL, на который нужно перейти
         
        }
    }
}