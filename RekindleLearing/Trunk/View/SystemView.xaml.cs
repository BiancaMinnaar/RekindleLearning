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
            BindingContext = _ViewController.InputObject;
        }

       void GetSystemInfo(object sender, EventArgs e)
        {
            _ViewController.GetSystemInfo()();
        } //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


