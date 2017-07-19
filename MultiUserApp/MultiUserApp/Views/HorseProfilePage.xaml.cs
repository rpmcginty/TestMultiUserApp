using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MultiUserApp.ViewModels;
using MultiUserApp.Models;

namespace MultiUserApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HorseProfilePage : ContentPage
	{
		public HorseProfilePage ()
		{
			InitializeComponent ();
		}

        async void OnSaveActivated(object sender, EventArgs e)
        {
            var horse = (Horse)BindingContext;
            await App.HorseManager.SaveTaskAsync(horse);
            await Navigation.PopAsync();
        }

        async void OnDeleteActivated(object sender, EventArgs e)
        {
            var horse = (Horse)BindingContext;
            await App.HorseManager.DeleteTaskAsync(horse);
            await Navigation.PopAsync();
        }

        async void OnCancelActivated(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}