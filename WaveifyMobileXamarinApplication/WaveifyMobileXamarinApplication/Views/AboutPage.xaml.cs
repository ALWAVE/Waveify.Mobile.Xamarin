using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaveifyMobileXamarinApplication.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            // Устанавливаем текст для Label
            StatusLabel.Text = "Передача данных...";
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                // После 2 секунд меняем текст на пустую строку или другой текст
                StatusLabel.Text = "Получение всех данных...";
                return false; // Возвращаем false, чтобы таймер не повторялся
            });
            // Здесь можно добавить задержку, чтобы имитировать передачу данных
            Device.StartTimer(TimeSpan.FromSeconds(8), () =>
            {
                // После 2 секунд меняем текст на пустую строку или другой текст
                StatusLabel.Text = "Гелька крутая Данные переданы!";
                StatusLabel.TextColor = Color.Green;
                return false; // Возвращаем false, чтобы таймер не повторялся
            });
        }
    }
}