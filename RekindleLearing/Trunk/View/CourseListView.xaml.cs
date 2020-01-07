using System;
using RekindleLearing.Implementation.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.View;
using Xamarin.Forms;

namespace RekindleLearing.Implementation.View
{
    public partial class CourseListView : ProjectBaseContentPage<CourseListViewController, CourseListViewModel>
    {
        public CourseListView()
        {
            InitializeComponent();
            _ViewController.GetCourseList()();
            BindingContext = _ViewController.InputObject;
        }

       void GetCourseList(object sender, EventArgs e)
        {
        } //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


