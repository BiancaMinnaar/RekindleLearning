using System;
using RekindleLearing.Implementation.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.View;
using Xamarin.Forms;

namespace RekindleLearing.Implementation.View
{
    public partial class DashboardView : ProjectBaseContentPage<DashboardViewController, DashboardViewModel>
    {
        public DashboardView()
        {
            InitializeComponent();
            BindingContext = _ViewController.InputObject;
        }

        void ShowAbout(object sender, EventArgs e)
        {
            _ViewController.ShowAbout()();
        }

        //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


