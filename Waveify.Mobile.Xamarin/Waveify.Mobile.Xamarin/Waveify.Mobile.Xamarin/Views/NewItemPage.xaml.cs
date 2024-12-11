using System;
using System.Collections.Generic;
using System.ComponentModel;
using Waveify.Mobile.Xamarin.Models;
using Waveify.Mobile.Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Waveify.Mobile.Xamarin.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}