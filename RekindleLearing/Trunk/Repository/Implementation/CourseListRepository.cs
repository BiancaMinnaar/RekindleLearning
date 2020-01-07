using System.Threading.Tasks;
using RekindleLearing.Root.Repository;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;

namespace RekindleLearing.Implementation.Repository
{
    public class CourseListRepository : ProjectBaseRepository, ICourseListRepository
    {
        ICourseListService<CourseListViewModel> _Service;
        
        public CourseListRepository(IMasterRepository masterRepository, ICourseListService<CourseListViewModel> service)
            : base(masterRepository)
        {
            _Service = service;
        }
        
        public async Task GetCourseListAsync(CourseListViewModel model)
        {
            var courses = await _Service.GetCourseList();
            model.Courses = courses.Courses;
        } //#Bonsai Snippets - MethodDefinitions
    }
}