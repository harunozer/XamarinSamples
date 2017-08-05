using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TasarimYapilari
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //MainPage = new StackLayout_Giris();
            //MainPage = new GridOrnek();
            //MainPage = new RelativeOrnek();
            MainPage = new AbsoluteOrnek();
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
