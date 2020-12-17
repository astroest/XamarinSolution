using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ONEUL.ViewModel;

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

            listItems = new List<ListItem>
            {
                new ListItem("운동", 10),
                new ListItem("강의", 23),
                new ListItem("코딩", 12),
                new ListItem("독서", 8)
            };

            main_list.ItemsSource = this.listItems;

        }
    }
}
