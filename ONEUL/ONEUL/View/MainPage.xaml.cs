using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ONEUL
{
    public partial class MainPage : TabbedPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            mainListView.ItemsSource = await App.Database.GetOneulsAsync();
        }

    }
}
