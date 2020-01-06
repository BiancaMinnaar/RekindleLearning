using System.Threading.Tasks;
using RekindleLearing.Interface.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.ViewController;
using RekindleLearing.Implementation.Repository;
using RekindleLearing.Implementation.Service;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;
//#Bonsai Snippets - Usings

namespace RekindleLearing.Implementation.ViewController
{
    public class SystemViewController : ProjectBaseViewController<SystemViewModel>, ISystemViewController
    {
        ISystemRepository<SystemViewModel> _Repository;
        ISystemService<SystemViewModel> _Service;
 //#Bonsai Snippets - Declarations
        public override void SetRepositories()
        {
            _Service = new SystemService<SystemViewModel>((U, C, A) => 
                ExecuteQueryWithReturnTypeAndNetworkAccessAsync<SystemViewModel>(U, C, A));
            _Repository = new SystemRepository<SystemViewModel>(_MasterRepo, _Service);
 //#Bonsai Snippets - ServicedRepos
        }
        
       public Func<Task> GetSystemInfo()
        {
            return async () =>
            {
                await _Repository.GetSystemInfoAsync(InputObject);
            };
        }
 //#Bonsai Snippets - Methods
    }
}