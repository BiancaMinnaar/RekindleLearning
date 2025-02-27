using System.Threading.Tasks;
using RekindleLearing.Trunk.ViewModel;

namespace RekindleLearing.Interface.Repository
{
    public interface IDashboardRepository<T>
    {
        Task ShowAboutAsync(DashboardViewModel model);
        Task SetNavigationCommandsAsync(DashboardViewModel model);
 //#Bonsai Snippets - MethodInterfaces
    }
}
