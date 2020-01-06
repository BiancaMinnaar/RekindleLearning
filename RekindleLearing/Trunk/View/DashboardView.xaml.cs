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
            _ViewController.SetNavigationCommands()();
            BindingContext = _ViewController.InputObject;
        }

        void ShowAbout(object sender, EventArgs e)
        {
            _ViewController.ShowAbout()();
        }

       void SetNavigationCommands(object sender, EventArgs e)
        {
            _ViewController.SetNavigationCommands()();
        } //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


