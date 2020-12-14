using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ONEUL
{
    public partial class MainPage : ContentPage
    {
        private List<ListItem> listItems;

        public MainPage()
        {
            InitializeComponent();

            listItems = new List<ListItem>();
            listItems.Add(new ListItem("운동", 10));
            listItems.Add(new ListItem("강의", 23));
            listItems.Add(new ListItem("코딩", 12));

            BindingContext = this;

        }
    }
}
