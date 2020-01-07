using System.Threading.Tasks;
using RekindleLearing.Trunk.ViewModel;

namespace RekindleLearing.Interface.Repository
{
    public interface ICourseDetailsRepository<T>
    {
       void GetCourseDetailsWithIDAsync(CourseDetailsViewModel model);
 //#Bonsai Snippets - MethodInterfaces
    }
}
