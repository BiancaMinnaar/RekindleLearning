using System.Threading.Tasks;
using RekindleLearing.Root.Repository;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;
using Xamarin.Forms;
using System;

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
            foreach(var course in courses.Courses)
            {
                course.NavigationCommand = new Command<Guid>(async (id) =>
                {
                    await Shell.Current.GoToAsync($"courseDetail?id={id}");
                });
            }
            model.Courses = courses.Courses;
            _MasterRepo.DataSource.CourseList = courses.Courses;
        } //#Bonsai Snippets - MethodDefinitions
    }
}