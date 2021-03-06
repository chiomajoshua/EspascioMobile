﻿using EspascioMobile.Views.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspascioMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        void RegisterRoutes()
        {
            Routing.RegisterRoute("Tasks/AddTask", typeof(AddTaskPage));
        }
    }
}