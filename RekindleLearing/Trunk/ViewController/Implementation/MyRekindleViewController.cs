using System.Threading.Tasks;
using RekindleLearing.Interface.ViewController;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Root.ViewController;
//#Bonsai Snippets - Usings

namespace RekindleLearing.Implementation.ViewController
{
    public class MyRekindleViewController : ProjectBaseViewController<MyRekindleViewModel>, IMyRekindleViewController
    {
        //#Bonsai Snippets - Declarations
        public override void SetRepositories()
        {
            //#Bonsai Snippets - ServicedRepos
        }
        
        //#Bonsai Snippets - Methods
    }
}