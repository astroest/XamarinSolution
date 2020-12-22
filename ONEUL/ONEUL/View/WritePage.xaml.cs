using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ONEUL.ViewModel;
using ONEUL.Model;

namespace ONEUL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WritePage : ContentPage
    {
        public ListItem Item { get; set; }

        public WritePage()
        {
            InitializeComponent();

            BindingContext = new WritePageViewModel();

        }
    }
}