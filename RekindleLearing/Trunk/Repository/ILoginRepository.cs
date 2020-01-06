using System.Threading.Tasks;
using RekindleLearing.Trunk.ViewModel;

namespace RekindleLearing.Interface.Repository
{
    public interface ILoginRepository<T>
    {
       Task LoginUserAsync(LoginViewModel model);
 //#Bonsai Snippets - MethodInterfaces
    }
}
