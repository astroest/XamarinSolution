using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ONEUL.ViewModel;
using ONEUL.Model;

namespace ONEUL
{
    public partial class MainPage : TabbedPage
    {
        readonly MainPageViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            //mainListView.ItemsSource = viewModel.listItems;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            mainListView.ItemsSource = await App.Database.GetOneulsAsync();
        }

    }
}
