﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspascioMobile.Views.Tasks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyTasksPage : ContentPage
    {
        public MyTasksPage()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }
    }
}