using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ONEUL.ViewModel
{
    public class MainPageViewModel : ContentPage
    {
        public Command addOneul { get; }
        public MainPageViewModel()
        {
            addOneul = new Command(OnAddOneul);
        }

        private async void OnAddOneul(object obj)
        {
            await Shell.Current.GoToAsync(nameof(WritePage));
            throw new NotImplementedException();
        }
    }
}