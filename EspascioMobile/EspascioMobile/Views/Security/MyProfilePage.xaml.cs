using System;
using System.ComponentModel;

using Xamarin.Forms;

namespace EspascioMobile.Views.Security
{
    [DesignTimeVisible(false)]
    public partial class MyProfilePage : ContentPage
    {
        public MyProfilePage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }
    }
}