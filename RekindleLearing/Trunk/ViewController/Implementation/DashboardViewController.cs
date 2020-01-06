using System.Threading.Tasks;
using RekindleLearing.Interface.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.ViewController;
using RekindleLearing.Implementation.Repository;
using RekindleLearing.Implementation.Service;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;
using System;
//#Bonsai Snippets - Usings

namespace RekindleLearing.Implementation.ViewController
{
    public class DashboardViewController : ProjectBaseViewController<DashboardViewModel>, IDashboardViewController
    {
        IDashboardRepository<DashboardViewModel> _Repository;
        IDashboardService<DashboardViewModel> _Service;
 //#Bonsai Snippets - Declarations
        public override void SetRepositories()
        {
            _Service = new DashboardService<DashboardViewModel>((U, C, A) => 
                ExecuteQueryWithReturnTypeAndNetworkAccessAsync<DashboardViewModel>(U, C, A));
            _Repository = new DashboardRepository<DashboardViewModel>(_MasterRepo, _Service);
 //#Bonsai Snippets - ServicedRepos
        }
        
       public Func<Task> ShowAbout()
        {
            return async () =>
            {
                await _Repository.ShowAboutAsync(InputObject);
            };
        }
public Func<Task> SetNavigationCommands()
        {
            return async () =>
            {
                await _Repository.SetNavigationCommandsAsync(InputObject);
            };
        }
 //#Bonsai Snippets - Methods
    }
}