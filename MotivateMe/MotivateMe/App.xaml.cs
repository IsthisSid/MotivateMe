using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MotivateMe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //   MainPage = new RandomFacts();
            //}
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.LightSkyBlue,
                BarTextColor = Color.White
            };

        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

