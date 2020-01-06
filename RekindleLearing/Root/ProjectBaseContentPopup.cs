using Rg.Plugins.Popup.Pages;
using RekindleLearing.Root.ViewController;
using RekindleLearing.Root.ViewModel;
using RekindleLearing.Trunk.Repository.Implementation;

namespace RekindleLearing.Root.View
{
    public abstract class ProjectBaseContentPopup<T, M> : PopupPage
        where T : ProjectBaseViewController<M>, new()
        where M : ProjectBaseViewModel, new()
    {
        protected T _ViewController;

        protected ProjectBaseContentPopup()
        {
            _ViewController = new T
            {
                InputObject = new M(),
                _MasterRepo = MasterRepository.MasterRepo
            };
            _ViewController.SetRepositories();
        }
    }
}
