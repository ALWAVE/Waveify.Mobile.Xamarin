using System;
using System.Threading.Tasks;
using System.Windows.Input;
using WaveifyMobileXamarinApplication.Services;
using WaveifyMobileXamarinApplication.Views;
using Xamarin.Forms;

namespace WaveifyMobileXamarinApplication.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string email;
        private string password;
        private readonly DatabaseServices databaseServices;

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            // Инициализация сервиса базы данных
            databaseServices = new DatabaseServices();
            LoginCommand = new Command(async () => await OnLoginClicked());
        }

        private async Task OnLoginClicked()
        {
            try
            {
                bool isValidUser = await databaseServices.ValidateUser(Email, Password);

                if (isValidUser)
                {
                    // Переход на главную страницу после успешной авторизации
                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                }
                else
                {
                    // Обработка неудачной авторизации (например, показать сообщение об ошибке)
                    await Application.Current.MainPage.DisplayAlert("Ошибка", "Неправильный логин или пароль", "OK");
                }
            }
            catch (Exception ex)
            {
                // Обработка исключений, например, проблемы с подключением к базе данных
                await Application.Current.MainPage.DisplayAlert("Ошибка", $"Произошла ошибка: {ex.Message}", "OK");
            }
        }
    }
}
