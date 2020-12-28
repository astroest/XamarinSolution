using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ONEUL.Model;

using Xamarin.Forms;

namespace ONEUL.ViewModel
{
    public class WritePageViewModel : ContentPage
    {
        public string inputTtile;
        public string inputMemo;
        public WritePageViewModel()
        {
            Command commandWrite = new Command(OnSaveOneul);
        }

        public string WriteTitle
        {
            get => inputTtile;
            set => SetProperty(ref inputTtile, value);
        }

        public string WriteMemo
        {
            get => inputMemo;
            set => SetProperty(ref inputMemo, value);
        }

        public Command commandWrite { get; }

        async void OnSaveOneul()
        {
            var oneul = (ListItem)BindingContext;
            oneul.Title = inputTtile;
            oneul.Memo = inputMemo;
            oneul.Time = DateTime.UtcNow;

            await App.Database.SaveOneulAsync(oneul);
            await Navigation.PopAsync();

            await Shell.Current.GoToAsync("..");
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

    }
}