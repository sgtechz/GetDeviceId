﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPrueba
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppPrueba.MainPage();
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
