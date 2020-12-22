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
        private List<ListItem> listItems;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new MainPageViewModel();

            main_list.ItemsSource = this.listItems;

        }
    }
}
