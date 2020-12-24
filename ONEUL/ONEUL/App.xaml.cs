using System;
using System.IO;
using Xamarin.Forms;
using ONEUL;

namespace ONEUL
{
    public partial class App : Application
    {
        static OneulDatabase database;

        public static OneulDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new OneulDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Oneul.db"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
