using System.Threading.Tasks;
using RekindleLearing.Root.Repository;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;
using Xamarin.Forms;
using System;

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

        public async Task SetNavigationCommandsAsync(DashboardViewModel model)
        {
            model.MyRekindleModel.ActionCommand = new Command(() => NavigateRoute()("myRekindle"));
            model.MyCoursesModel.ActionCommand = new Command(() => NavigateRoute()("myCourses"));
            model.MoreCoursesModel.ActionCommand = new Command(() => NavigateRoute()("courseList"));
            model.KnowledgeMatchModel.ActionCommand = new Command(() => NavigateRoute()("knowledgeMatch"));
            model.NoCourseWideModel.CourseListNavigation = new Command(() => NavigateRoute()("myCourses"));
        }

        Func<string, Task> NavigateRoute()
        {
            return async (route) => await Shell.Current.GoToAsync(route);
        }

        //#Bonsai Snippets - MethodDefinitions
    }
}