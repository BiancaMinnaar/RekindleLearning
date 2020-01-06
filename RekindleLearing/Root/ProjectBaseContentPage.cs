using System;
using System.Reflection;
using RekindleLearing.Root.ViewController;
using RekindleLearing.Root.ViewModel;
using RekindleLearing.Trunk.Repository.Implementation;
using Xamarin.Forms;

namespace RekindleLearing.Root.View
{
    public abstract class ProjectBaseContentPage<T, M> : ContentPage
        where T: ProjectBaseViewController<M>, new()
        where M: ProjectBaseViewModel, new()
    {
        protected T _ViewController;

        protected ProjectBaseContentPage()
        {
            try
            {
                _ViewController = new T();
            }
            catch(TargetInvocationException excp)
            {
                throw new Exception("Bonsai Licence Failure");
            }
            _ViewController.InputObject = new M();
            _ViewController._MasterRepo = MasterRepository.MasterRepo;
            _ViewController.SetRepositories();
        }
    }
}