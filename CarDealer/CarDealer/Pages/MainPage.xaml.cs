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
   public partial class MainPage : ContentPage
   {
      MainViewModel _viewModel;

      public MainPage()
      {
         InitializeComponent();

         BindingContext = _viewModel = new MainViewModel();
      }

      private async void OnHomeInventoryTapped(Object sender, EventArgs e)
      {
         await Navigation.PushModalAsync(new InventoryPage());
      }

      private async void OnHomeServiceRequestTapped(Object sender, EventArgs e)
      {
         await Navigation.PushModalAsync(new ServiceRequestPage());
      }

      private async void OnHomePromotionsTapped(Object sender, EventArgs e)
      {
         await Navigation.PushModalAsync(new FeaturedPage());
      }

   }
}
