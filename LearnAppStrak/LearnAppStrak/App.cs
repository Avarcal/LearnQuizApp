using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;

using Xamarin.Forms;

namespace LearnAppStrak
{
    public class App : Application
    {
        public App()
        {

            MainPage = GetMainPage();
            // The root page of your application
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                XAlign = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};
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
        public static Page GetMainPage()
        {
            // Replace the ExamplePage with whatever page is appropriate to start off your app
            //  - Like your login page, or home screen, or whatever
            return new NavigationPage(new LoginPage());
        }
    }
}
