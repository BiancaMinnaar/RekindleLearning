using System;
using RekindleLearing.Implementation.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.View;
using Xamarin.Forms;

namespace RekindleLearing.Implementation.View
{
    [QueryProperty("UID", "id")]
    public partial class CourseDetailsView : ProjectBaseContentPage<CourseDetailsViewController, CourseDetailsViewModel>
    {
        public string UID
        {
            set
            {
                _ViewController.InputObject.UID = value;
                _ViewController.GetCourseDetailsWithID();
                BindingContext = _ViewController.InputObject;
            }
        }

        public CourseDetailsView()
        {
            InitializeComponent();
        }

        //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


