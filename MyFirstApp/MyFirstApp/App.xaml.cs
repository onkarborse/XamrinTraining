﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new Calculator();
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

