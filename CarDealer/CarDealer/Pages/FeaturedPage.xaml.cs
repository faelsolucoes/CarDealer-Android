using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Models;
using Xamarin.Forms;
using CarDealer.ViewModels;

namespace CarDealer.Pages
{
   public partial class FeaturedPage : ContentPage
   {
      FeaturedViewModel _viewModel;

      public FeaturedPage()
      {
         InitializeComponent();

         BindingContext = _viewModel = new FeaturedViewModel();
      }

      private async void OnBackTapped(Object sender, EventArgs e)
      {
         await Navigation.PopModalAsync();
      }

   }
}
