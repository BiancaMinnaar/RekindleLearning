using System.Threading.Tasks;
using RekindleLearing.Root.Repository;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;
using System.Linq;
using System.Net;

namespace RekindleLearing.Implementation.Repository
{
    public class CourseDetailsRepository<T> : ProjectBaseRepository, ICourseDetailsRepository<T>
    {
        ICourseDetailsService<T> _Service;
        
        public CourseDetailsRepository(IMasterRepository masterRepository, ICourseDetailsService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }
        
       public void GetCourseDetailsWithIDAsync(CourseDetailsViewModel model)
        {
            var course = _MasterRepo.DataSource.CourseList.FirstOrDefault(a => a.Uid.ToString().Equals(model.UID));
            model.CourseImage = course.CourseImage;
            model.CardsCount = course.Cards?.Count().ToString();
            model.LessonsCount = course.Lessons?.Count().ToString();
            model.CourseTitle = course.Title;
            model.Introduction = WebUtility.HtmlDecode(course.Introducton);
            //model.Description = course.
        } //#Bonsai Snippets - MethodDefinitions
    }
}