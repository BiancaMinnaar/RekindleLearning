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
    public class CourseDetailsViewController : ProjectBaseViewController<CourseDetailsViewModel>, ICourseDetailsViewController
    {
        ICourseDetailsRepository<CourseDetailsViewModel> _Repository;
        ICourseDetailsService<CourseDetailsViewModel> _Service;
 //#Bonsai Snippets - Declarations
        public override void SetRepositories()
        {
            _Service = new CourseDetailsService<CourseDetailsViewModel>((U, C, A) => 
                ExecuteQueryWithReturnTypeAndNetworkAccessAsync<CourseDetailsViewModel>(U, C, A));
            _Repository = new CourseDetailsRepository<CourseDetailsViewModel>(_MasterRepo, _Service);
 //#Bonsai Snippets - ServicedRepos
        }
        
       public void GetCourseDetailsWithID()
        {
            _Repository.GetCourseDetailsWithIDAsync(InputObject);
        }
 //#Bonsai Snippets - Methods
    }
}