using System;
using RekindleLearing.Implementation.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.View;
using Xamarin.Forms;

namespace RekindleLearing.Implementation.View
{
    public partial class MyCoursesView : ProjectBaseContentPage<MyCoursesViewController, MyCoursesViewModel>
    {
        public MyCoursesView()
        {
            InitializeComponent();
            BindingContext = _ViewController.InputObject;
        }

        //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


