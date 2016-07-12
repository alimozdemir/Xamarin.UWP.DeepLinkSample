using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin.UWP.DeepLinkSample
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            //In case, if you have to upcoming uri in any page. You can easily adapt like this.
            App app = App.Current as App;
            app.OnDeepLinkRequest += App_OnDeepLinkRequest;

            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            App app = App.Current as App;
            app.OnDeepLinkRequest -= App_OnDeepLinkRequest;

            base.OnDisappearing();
        }

        private void App_OnDeepLinkRequest(Uri parameter)
        {
            //Handle the upcoming request
            DisplayAlert("Page1", parameter.ToString(), "Cancel");
        }

    }
}
