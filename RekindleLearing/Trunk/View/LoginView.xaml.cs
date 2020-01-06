using System;
using RekindleLearing.Implementation.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.View;
using Xamarin.Forms;

namespace RekindleLearing.Implementation.View
{
    public partial class LoginView : ProjectBaseContentPage<LoginViewController, LoginViewModel>
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = _ViewController.InputObject;
        }

       void LoginUser(object sender, EventArgs e)
        {
            _ViewController.LoginUser()();
        } //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


