using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FormKontrolleri
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //MainPage = new KontrollerOrnek();
            //MainPage = new WebViewOrnek();
            MainPage = new TableViewSample();
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
