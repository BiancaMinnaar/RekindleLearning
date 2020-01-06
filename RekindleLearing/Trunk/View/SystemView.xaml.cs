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
            _ViewController.GetSystemInfo()();
            BindingContext = _ViewController.InputObject;
        }

        //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


