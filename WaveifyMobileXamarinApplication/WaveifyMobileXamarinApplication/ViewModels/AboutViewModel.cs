using System;
using System.Windows.Input;
using WaveifyMobileXamarinApplication.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WaveifyMobileXamarinApplication.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ICommand LoginPageView { get; private set; }
        public AboutViewModel()
        {
            Title = "Waveify";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            LoginPageView = new Command(OnLoginPageView);
        }
        public ICommand OpenWebCommand { get; }
        private async void OnLoginPageView()
        {
            // Здесь вы можете заменить текущую страницу на новую
            var loginPage = new LoginPage(); // Предполагается, что у вас есть LoginPage
            await Application.Current.MainPage.Navigation.PushAsync(loginPage);
        }
    }
}