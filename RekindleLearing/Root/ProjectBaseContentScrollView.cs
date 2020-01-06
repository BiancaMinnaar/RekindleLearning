using RekindleLearing.Root.ViewController;
using RekindleLearing.Root.ViewModel;
using RekindleLearing.Trunk.Repository.Implementation;
using Xamarin.Forms;

namespace RekindleLearing.Root.View
{
    public abstract class ProjectBaseContentScrollView<T, M> : ScrollView
        where T : ProjectBaseViewController<M>, new()
        where M : ProjectBaseViewModel
    {
        protected T _ViewController;

        protected ProjectBaseContentScrollView()
        {
            _ViewController = new T();
            SetSVGCollection();
            _ViewController._MasterRepo = MasterRepository.MasterRepo;
            _ViewController.SetRepositories();
        }

        protected abstract void SetSVGCollection();
    }
}