using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ONEUL.Model;

using Xamarin.Forms;

namespace ONEUL.ViewModel
{
    public class WritePageViewModel : ContentPage
    {
        public string inputTtile { get; }
        public string inputMemo { get; }
        public DateTime inputTimre { get; }

        public WritePageViewModel()
        {
            Command commandWrite = new Command(OnSaveOneul);
        }

        async void OnSaveOneul()
        {
            var oneul = (ListItem)BindingContext;
            oneul.Time = DateTime.UtcNow;
            await App.Database.SaveOneulAsync(oneul);
            await Navigation.PopAsync();
        }

        async void OnDeleteOneul()
        {
            var oneul = (ListItem)BindingContext;
            await App.Database.DeleteOneulAsync(oneul);
            await Navigation.PopAsync();
        }

    }
}