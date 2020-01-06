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
    public class LoginViewController : ProjectBaseViewController<LoginViewModel>, ILoginViewController
    {
        ILoginRepository<LoginViewModel> _Repository;
        ILoginService<LoginViewModel> _Service;
 //#Bonsai Snippets - Declarations
        public override void SetRepositories()
        {
            _Service = new LoginService<LoginViewModel>((U, C, A) => 
                ExecuteQueryWithReturnTypeAndNetworkAccessAsync<LoginViewModel>(U, C, A));
            _Repository = new LoginRepository<LoginViewModel>(_MasterRepo, _Service);
 //#Bonsai Snippets - ServicedRepos
        }
        
       public Func<Task> LoginUser()
        {
            return async () =>
            {
                await _Repository.LoginUserAsync(InputObject);
            };
        }
 //#Bonsai Snippets - Methods
    }
}