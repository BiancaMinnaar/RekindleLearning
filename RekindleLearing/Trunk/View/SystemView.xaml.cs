using System;
using RekindleLearing.Implementation.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.View;
using Xamarin.Forms;

namespace RekindleLearing.Implementation.View
{
    public partial class SystemView : ProjectBaseContentPage<SystemViewController, SystemViewModel>
    {
        public SystemView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        //#Bonsai Snippets - ViewControllerMethodCalls
    }
}
