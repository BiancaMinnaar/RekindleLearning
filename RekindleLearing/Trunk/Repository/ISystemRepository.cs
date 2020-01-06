using System.Threading.Tasks;
using RekindleLearing.Trunk.ViewModel;

namespace RekindleLearing.Interface.Repository
{
    public interface ISystemRepository<T>
    {
       Task GetSystemInfoAsync(SystemViewModel model);
 //#Bonsai Snippets - MethodInterfaces
    }
}
