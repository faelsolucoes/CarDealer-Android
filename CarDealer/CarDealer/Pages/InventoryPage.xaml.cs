using CarDealer.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CarDealer.Pages
{
	public partial class InventoryPage : ContentPage
	{
      InventoryViewModel _viewModel;

      public InventoryPage()
		{
			InitializeComponent ();

         BindingContext = _viewModel = new InventoryViewModel();
		}

      private async void OnBackTapped(Object sender, EventArgs e)
      {
         await Navigation.PopModalAsync();
      }

   }
}