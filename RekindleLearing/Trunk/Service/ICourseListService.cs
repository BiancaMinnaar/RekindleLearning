using System.Threading.Tasks;
using RekindleLearing.Trunk.ViewModel;

namespace RekindleLearing.Interface.Service
{
    public interface ICourseListService<T>
    {
        Task<T> GetCourseList();
        //#Bonsai Snippets - MethodInterfaces
    }
}

