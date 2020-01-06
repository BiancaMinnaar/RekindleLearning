using System.Threading.Tasks;
using RekindleLearing.Root.Repository;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;
using Xamarin.Forms;

namespace RekindleLearing.Implementation.Repository
{
    public class LoginRepository<T> : ProjectBaseRepository, ILoginRepository<T>
    {
        ILoginService<T> _Service;
        
        public LoginRepository(IMasterRepository masterRepository, ILoginService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }
        
        public async Task LoginUserAsync(LoginViewModel model)
        {
            model.LoginModel.IsLoggedIn = true;
            if (model.LoginModel.IsLoggedIn)
                await Shell.Current.GoToAsync("dashboard");
        } //#Bonsai Snippets - MethodDefinitions
    }
}