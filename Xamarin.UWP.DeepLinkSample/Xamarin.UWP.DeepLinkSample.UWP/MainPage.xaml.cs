using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Xamarin.UWP.DeepLinkSample.UWP
{
    //Short way to call a class
    using AppType = Xamarin.UWP.DeepLinkSample.UWP.App;

    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            AppType app = App.Current as AppType; 
            LoadApplication(app.XApp);
        }
    }
}
