using System.ComponentModel;
using Waveify.Mobile.Xamarin.ViewModels;
using Xamarin.Forms;

namespace Waveify.Mobile.Xamarin.Views
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