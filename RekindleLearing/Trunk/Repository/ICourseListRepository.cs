using System.Threading.Tasks;
using RekindleLearing.Trunk.ViewModel;

namespace RekindleLearing.Interface.Repository
{
    public interface ICourseListRepository
    {
       Task GetCourseListAsync(CourseListViewModel model);
 //#Bonsai Snippets - MethodInterfaces
    }
}
