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
        private List<ListItem> listItems;

        public MainPage()
        {
            InitializeComponent();

            listItems = new List<ListItem>
            {
                new ListItem("운동", 10),
                new ListItem("강의", 23),
                new ListItem("코딩", 12)
            };

            main_list.ItemsSource = listItems;
            main_list.BindingContext = listItems;

        }
    }
}
