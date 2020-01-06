using System.Threading.Tasks;
using RekindleLearing.Root.Repository;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;
using Xamarin.Forms;

namespace RekindleLearing.Implementation.Repository
{
    public class DashboardRepository<T> : ProjectBaseRepository, IDashboardRepository<T>
    {
        IDashboardService<T> _Service;
        
        public DashboardRepository(IMasterRepository masterRepository, IDashboardService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }
        
        public async Task ShowAboutAsync(DashboardViewModel model)
        {
            await Shell.Current.GoToAsync("system");
        }

        //#Bonsai Snippets - MethodDefinitions
    }
}