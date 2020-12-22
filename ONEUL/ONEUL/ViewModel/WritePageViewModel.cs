using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ONEUL.Model;

using Xamarin.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ONEUL.ViewModel
{
    public class WritePageViewModel : ContentPage
    {
        private string inputTitle;
        private string inputMemo;

        public String WriteTitle { get; }
        public String WriteMemo { get; }

        public WritePageViewModel()
        {
            Command commandWrite = new Command(CommandWrite);
        }

        private async void CommandWrite()
        {
            _ = new ListItem()
            {
                Title = inputTitle,
                Memo = inputMemo
            };

            await Shell.Current.GoToAsync("..");
        }

        public string InputTitle
        {
            get => inputTitle;
            set => SetProperty(ref inputTitle, value);
        }

        public string InputMemo
        {
            get => inputMemo;
            set => SetProperty(ref inputMemo, value);
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