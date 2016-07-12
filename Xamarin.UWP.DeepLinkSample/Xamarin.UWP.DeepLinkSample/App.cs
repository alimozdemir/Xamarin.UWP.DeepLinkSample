using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin.UWP.DeepLinkSample
{
    public class App : Application
    {
        public delegate void DeepLinkRequestDelegate(Uri parameter);
        public event DeepLinkRequestDelegate OnDeepLinkRequest;

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new Page1());
            OnDeepLinkRequest += App_OnDeepLinkRequest;
        }

        //To handle navigation
        private void App_OnDeepLinkRequest(Uri parameter)
        {
            var page = MainPage as NavigationPage;
            if (parameter.Query.Equals("?Page1"))
            {
                page.PushAsync(new Page1());
            }
            else if (parameter.Query.Equals("?Page2"))
            {
                page.PushAsync(new Page2());
            }
        }
        
        //To trigger event
        public void DeepLinkRequest(Uri uri)
        {
            OnDeepLinkRequest(uri);
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
