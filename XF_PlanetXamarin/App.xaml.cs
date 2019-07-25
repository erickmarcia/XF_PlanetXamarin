﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XF_PlanetXamarin.Views;
using XF_PlanetXamarin.Views.TestAB;

namespace XF_PlanetXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TestBlogPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
