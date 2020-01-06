using System;
using RekindleLearing.Implementation.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.View;
using Xamarin.Forms;

namespace RekindleLearing.Implementation.View
{
    public partial class KnowledgeMatchView : ProjectBaseContentPage<KnowledgeMatchViewController, KnowledgeMatchViewModel>
    {
        public KnowledgeMatchView()
        {
            InitializeComponent();
            BindingContext = _ViewController.InputObject;
        }

        //#Bonsai Snippets - ViewControllerMethodCalls
    }
}


