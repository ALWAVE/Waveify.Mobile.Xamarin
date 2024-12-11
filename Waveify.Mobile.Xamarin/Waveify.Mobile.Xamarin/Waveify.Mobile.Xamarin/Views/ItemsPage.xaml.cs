using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waveify.Mobile.Xamarin.Models;
using Waveify.Mobile.Xamarin.ViewModels;
using Waveify.Mobile.Xamarin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Waveify.Mobile.Xamarin.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}