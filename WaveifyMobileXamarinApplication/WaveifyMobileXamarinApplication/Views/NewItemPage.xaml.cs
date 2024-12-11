using System;
using System.Collections.Generic;
using System.ComponentModel;
using WaveifyMobileXamarinApplication.Models;
using WaveifyMobileXamarinApplication.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaveifyMobileXamarinApplication.Views
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