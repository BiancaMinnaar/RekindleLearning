using System;
using RekindleLearing.Implementation.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.View;
using Xamarin.Forms;

namespace RekindleLearing.Implementation.View
{
    [QueryProperty("UID", "id")]
    public partial class QuestionPadView : ProjectBaseContentPage<QuestionPadViewController, QuestionPadViewModel>
    {
        public string UID
        {
            set
            {
                _ViewController.InputObject.ID = value;
                _ViewController.GetCardsForID();
                _ViewController.SetNavigation()();
                BindingContext = _ViewController.InputObject;
            }
        }

        public QuestionPadView()
        {
            InitializeComponent();
        }

       void SetNavigation(object sender, EventArgs e)
        {
            _ViewController.SetNavigation()();
        } //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


