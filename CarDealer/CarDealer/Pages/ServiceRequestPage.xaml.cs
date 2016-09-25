using System;
using CarDealer.ViewModels;
using Xamarin.Forms;
using CarDealer.Models;

namespace CarDealer.Pages
{
	public partial class ServiceRequestPage : ContentPage
	{
      ServiceRequestViewModel _viewModel;

      public ServiceRequestPage()
		{
			InitializeComponent ();

			this.BindingContext = _viewModel = new ServiceRequestViewModel();

         // Atualiza a lista de measure na tela
         this.pckServiceType.Items.Clear();
         foreach (var type in SampleData.ServiceTypeList())
            pckServiceType.Items.Add(type);
      }

      private async void OnBackTapped(Object sender, EventArgs e)
      {
         await Navigation.PopModalAsync();
      }

      private async void OnSaveTapped(Object sender, EventArgs e)
      {
         await DisplayAlert("Alert", "Service request saved.", "OK");

         await Navigation.PopModalAsync();
      }
   }
}