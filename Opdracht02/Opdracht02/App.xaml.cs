﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht02
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StartPage();
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
