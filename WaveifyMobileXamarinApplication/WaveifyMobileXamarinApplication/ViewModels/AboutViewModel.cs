using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WaveifyMobileXamarinApplication.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WaveifyMobileXamarinApplication.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ICommand LoginPageView { get; private set; }
        //Best Artist
        private string bestNameArtist;
        private string bestNameSongArtist;
        private string bestSongArtistUrlImage;
        //Cart music
        private string chart1NameArtist;
        private string chart1NameSongArtist;
        private string chart1SongArtistUrlImage;
        private string chart2NameArtist;
        private string chart2NameSongArtist;
        private string chart2SongArtistUrlImage;
        private string chart3NameArtist;
        private string chart3NameSongArtist;
        private string chart3SongArtistUrlImage;
        private string chart4NameArtist;
        private string chart4NameSongArtist;
        private string chart4SongArtistUrlImage;
        private string chart5NameArtist;
        private string chart5NameSongArtist;
        private string chart5SongArtistUrlImage;


        public string BestNameArtist
        {
            get => bestNameArtist;
            set
            {
                bestNameArtist = value;
                OnPropertyChanged();
            }
        }
        public string BestNameSongArtist
        {
            get => bestNameSongArtist;
            set
            {
                bestNameSongArtist = value;
                OnPropertyChanged();
            }
        }
        public string BestSongArtistUrlImage
        {
            get => bestSongArtistUrlImage;
            set
            {
                bestSongArtistUrlImage = value;
                OnPropertyChanged();
            }
        }
        //Chart music
        public string Chart1NameArtist
        {
            get => chart1NameArtist;
            set
            {
                chart1NameArtist = value;
                OnPropertyChanged();
            }
        }
        public string Chart1NameSongArtist
        {
            get => chart1NameSongArtist;
            set
            {
                chart1NameSongArtist = value;
                OnPropertyChanged();
            }
        }
        public string Chart1SongArtistUrlImage
        {
            get => chart1SongArtistUrlImage;
            set
            {
                chart1SongArtistUrlImage = value;
                OnPropertyChanged();
            }
        }

        public string Chart2NameArtist
        {
            get => chart2NameArtist;
            set
            {
                chart2NameArtist = value;
                OnPropertyChanged();
            }
        }
        public string Chart2NameSongArtist
        {
            get => chart2NameSongArtist;
            set
            {
                chart2NameSongArtist = value;
                OnPropertyChanged();
            }
        }
        public string Chart2SongArtistUrlImage
        {
            get => chart2SongArtistUrlImage;
            set
            {
                chart2SongArtistUrlImage = value;
                OnPropertyChanged();
            }
        }

        public string Chart3NameArtist
        {
            get => chart3NameArtist;
            set
            {
                chart3NameArtist = value;
                OnPropertyChanged();
            }
        }
        public string Chart3NameSongArtist
        {
            get => chart3NameSongArtist;
            set
            {
                chart3NameSongArtist = value;
                OnPropertyChanged();
            }
        }
        public string Chart3SongArtistUrlImage
        {
            get => chart3SongArtistUrlImage;
            set
            {
                chart3SongArtistUrlImage = value;
                OnPropertyChanged();
            }
        }

        public string Chart4NameArtist
        {
            get => chart4NameArtist;
            set
            {
                chart4NameArtist = value;
                OnPropertyChanged();
            }
        }
        public string Chart4NameSongArtist
        {
            get => chart4NameSongArtist;
            set
            {
                chart4NameSongArtist = value;
                OnPropertyChanged();
            }
        }
        public string Chart4SongArtistUrlImage
        {
            get => chart4SongArtistUrlImage;
            set
            {
                chart4SongArtistUrlImage = value;
                OnPropertyChanged();
            }
        }

        public string Chart5NameArtist
        {
            get => chart5NameArtist;
            set
            {
                chart5NameArtist = value;
                OnPropertyChanged();
            }
        }
        public string Chart5NameSongArtist
        {
            get => chart5NameSongArtist;
            set
            {
                chart5NameSongArtist = value;
                OnPropertyChanged();
            }
        }
        public string Chart5SongArtistUrlImage
        {
            get => chart5SongArtistUrlImage;
            set
            {
                chart5SongArtistUrlImage = value;
                OnPropertyChanged();
            }
        }

        public AboutViewModel()
        {
            Title = "Waveify";
            CompletionContent();
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            LoginPageView = new Command(OnLoginPageView);
        }
        public ICommand OpenWebCommand { get; }
        private void CompletionContent()
        {

            //Best Artist
            BestNameArtist = "Travis Scott"; // Замените на нужные данные
            BestNameSongArtist = "Utopia"; // Замените на нужные данные
            bestSongArtistUrlImage = "https://media.npr.org/assets/img/2021/11/16/gettyimages-1235223332_sq-e88ad790d447bd7dfcb0c1571047db26d39a8ee0.jpg";

            //Chart artist
            Chart1NameArtist = "The Weeknd"; // Замените на нужные данные
            Chart1NameSongArtist = "Blinding Lights"; // Замените на нужные данные
            Chart1SongArtistUrlImage = "https://upload.wikimedia.org/wikipedia/ru/7/75/Blinding_Lights.jpg";

            Chart2NameArtist = "Drake"; // Замените на нужные данные
            Chart2NameSongArtist = "God's Plan"; // Замените на нужные данные
            Chart2SongArtistUrlImage = "https://i1.sndcdn.com/artworks-JHJL0Q9mpSCDOzXF-5hLCAg-t500x500.jpg";

            Chart3NameArtist = "Billie Eilish"; // Замените на нужные данные
            Chart3NameSongArtist = "Bad Guy"; // Замените на нужные данные
            Chart3SongArtistUrlImage = "https://i1.sndcdn.com/artworks-000515071536-pwrtb4-t500x500.jpg";

            Chart4NameArtist = "Kendrick Lamar"; // Замените на нужные данные
            Chart4NameSongArtist = "Humble"; // Замените на нужные данные
            Chart4SongArtistUrlImage = "https://upload.wikimedia.org/wikipedia/ru/c/c2/Humble.jpg";

            Chart5NameArtist = "Taylor Swift"; // Замените на нужные данные
            Chart5NameSongArtist = "Shake It Off"; // Замените на нужные данные
            Chart5SongArtistUrlImage = "https://upload.wikimedia.org/wikipedia/ru/f/fb/Shake_It_Off.jpg";
        }
        private async void OnLoginPageView()
        {
           
            var pofilePage = new ProfilePage(); 
            await Application.Current.MainPage.Navigation.PushAsync(pofilePage);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}