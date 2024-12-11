using System.ComponentModel;
using WaveifyMobileXamarinApplication.ViewModels;
using Xamarin.Forms;

namespace WaveifyMobileXamarinApplication.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}