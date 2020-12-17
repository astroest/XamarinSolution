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
                new ListItem("운동", "팔굽혀펴기"),
                new ListItem("강의", "서버운영실습"),
                new ListItem("코딩", "메인화면 수정"),
                new ListItem("독서", "추리소설")
            };

            main_list.ItemsSource = this.listItems;

        }
    }
}
