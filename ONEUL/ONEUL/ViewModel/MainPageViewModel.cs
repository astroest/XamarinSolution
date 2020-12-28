using System;
using System.Collections.Generic;
using ONEUL.Model;

using Xamarin.Forms;

namespace ONEUL.ViewModel
{
    public class MainPageViewModel
    {
        public List<ListItem> listItems { get; set; }
        public Command addOneul { get; }
        public MainPageViewModel()
        {

            listItems = new List<ListItem>();

            addOneul = new Command(OnAddOneul);
        }

        private async void OnAddOneul(object obj)
        {
            await Shell.Current.GoToAsync(nameof(WritePage));
            throw new NotImplementedException();
        }

    }

}