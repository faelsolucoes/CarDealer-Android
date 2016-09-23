using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Models;
using Xamarin.Forms;

namespace CarDealer.Pages
{
    public partial class AdminPage : ContentPage
    {

        ObservableCollection<ImageSource> _images;
        int idx;

        public AdminPage()
        {
            InitializeComponent();

            idx = 2;
            BindingContext = this;
        }

        public List<Restaurant> CarDealer
        {
            get
            {
                return SampleData.Tables;
            }
        }

        public List<Restaurant> Favorites
        {
            get
            {
                return new List<Restaurant>() {
                    SampleData.CarDealer[0],
                    SampleData.CarDealer[3],
                    SampleData.CarDealer[4],
                };
            }
        }

        public ObservableCollection<ImageSource> Images
        {
            get
            {
                return _images;
            }

            set
            {
                _images = value; OnPropertyChanged();
            }
        }

        public async void OnItemTapped(object sender, EventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem;
            var post = (Restaurant)selectedItem;
            var articleView = new DetailViewPage(new ViewModels.DetailViewModel(post));
            try
            {
                await App.Current.Navigation.PushAsync(articleView);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
