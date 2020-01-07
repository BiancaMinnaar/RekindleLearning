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
            Routing.RegisterRoute("myRekindle", typeof(MyRekindleView));
            Routing.RegisterRoute("myCourses", typeof(MyCoursesView));
            Routing.RegisterRoute("courseList", typeof(CourseListView));
            Routing.RegisterRoute("knowledgeMatch", typeof(KnowledgeMatchView));
            Routing.RegisterRoute("courseDetail", typeof(CourseDetailsView));
            //#Bonsai Snippets - Routes
        }
    }
}