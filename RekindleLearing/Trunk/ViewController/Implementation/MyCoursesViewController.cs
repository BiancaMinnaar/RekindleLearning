using System.Threading.Tasks;
using RekindleLearing.Interface.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.ViewController;
//#Bonsai Snippets - Usings

namespace RekindleLearing.Implementation.ViewController
{
    public class MyCoursesViewController : ProjectBaseViewController<MyCoursesViewModel>, IMyCoursesViewController
    {
        //#Bonsai Snippets - Declarations
        public override void SetRepositories()
        {
            //#Bonsai Snippets - ServicedRepos
        }
        
        //#Bonsai Snippets - Methods
    }
}