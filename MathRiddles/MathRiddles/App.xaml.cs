using MathRiddles.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MathRiddles
{
    public partial class App : Application
    {
        static MathRiddlesDatabase database;

        public static MathRiddlesDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new MathRiddlesDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MathRiddle.db3"));
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
