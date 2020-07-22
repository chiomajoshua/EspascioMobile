using EspascioMobile.Views.Dashboard;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspascioMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //

            //MainPage = new AppShell();
            Device.SetFlags(new[] { "Shapes_Experimental", "MediaElement_Experimental" });
            var splashPage = new NavigationPage(new SplashPage());
            MainPage = splashPage;
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.White);

            //Title color
            MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.Black);
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
