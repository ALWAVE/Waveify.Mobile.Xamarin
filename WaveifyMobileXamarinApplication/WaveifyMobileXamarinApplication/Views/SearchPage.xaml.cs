using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveifyMobileXamarinApplication.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaveifyMobileXamarinApplication.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchPage : ContentPage
	{
		public SearchPage ()
		{
			InitializeComponent ();
            this.BindingContext = new SearchViewModel();
        }
	}
}