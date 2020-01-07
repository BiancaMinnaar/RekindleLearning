using System.Threading.Tasks;
using RekindleLearing.Interface.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.ViewController;
using RekindleLearing.Implementation.Repository;
using RekindleLearing.Implementation.Service;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;
using System;
//#Bonsai Snippets - Usings

namespace RekindleLearing.Implementation.ViewController
{
    public class CourseListViewController : ProjectBaseViewController<CourseListViewModel>, ICourseListViewController
    {
        ICourseListRepository _Repository;
        ICourseListService<CourseListViewModel> _Service;
 //#Bonsai Snippets - Declarations
        public override void SetRepositories()
        {
            _Service = new CourseListService<CourseListViewModel>((U, C, A) => 
                ExecuteQueryWithReturnTypeAndNetworkAccessAsync<CourseListViewModel>(U, C, A));
            _Repository = new CourseListRepository(_MasterRepo, _Service);
 //#Bonsai Snippets - ServicedRepos
        }
        
       public Func<Task> GetCourseList()
        {
            return async () =>
            {
                await _Repository.GetCourseListAsync(InputObject);
            };
        }
 //#Bonsai Snippets - Methods
    }
}