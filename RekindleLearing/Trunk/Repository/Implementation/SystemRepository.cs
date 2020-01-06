using System.Threading.Tasks;
using RekindleLearing.Root.Repository;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;

namespace RekindleLearing.Implementation.Repository
{
    public class SystemRepository<T> : ProjectBaseRepository, ISystemRepository<T>
    {
        ISystemService<T> _Service;
        
        public SystemRepository(IMasterRepository masterRepository, ISystemService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }
        
       public async Task GetSystemInfoAsync(SystemViewModel model)
        {
            var yourData = new SystemViewModel
            {
                //#Bonsai Snippets - Projection
            };
        } //#Bonsai Snippets - MethodDefinitions
    }
}