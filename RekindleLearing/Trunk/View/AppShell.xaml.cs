using System;
using System.Collections.Generic;
using RekindleLearing.Implementation.View;
using Xamarin.Forms;

namespace RekindleLearing.Trunk.View
{
    public partial class AppShell : Shell
    {
        public Dictionary<string, Type> Routes { get; } = new Dictionary<string, Type>();

        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute("system", typeof(SystemView));
            Routing.RegisterRoute("login", typeof(LoginView));
            Routing.RegisterRoute("dashboard", typeof(DashboardView));
            //#Bonsai Snippets - Routes
        }
    }
}