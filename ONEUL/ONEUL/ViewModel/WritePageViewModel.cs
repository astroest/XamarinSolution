using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ONEUL.ViewModel
{
    public class WritePageViewModel : ContentPage
    {
        private string inputTitle;
        private string inputMemo;

        public Command WriteTitle { get; }
        public Command WriteMemo { get; }

        public WritePageViewModel()
        {
            WriteTitle = new Command(OnWriteTitle);
            WriteMemo = new Command(OnWriteMemo);
        }

        public string Title
        {
            get => inputTitle;
            set => SetProperty(ref inputTitle, value);
        }

        public string Description
        {
            get => inputMemo;
            set => SetProperty(ref inputMemo, value);
        }

        private void SetProperty(ref string inputMemo, string value)
        {
            throw new NotImplementedException();
        }

        private void OnWriteMemo(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnWriteTitle(object obj)
        {
            throw new NotImplementedException();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(inputTitle)
                && !String.IsNullOrWhiteSpace(inputMemo);
        }

    }
}