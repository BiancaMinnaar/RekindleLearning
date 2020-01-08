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
    public class QuestionPadViewController : ProjectBaseViewController<QuestionPadViewModel>, IQuestionPadViewController
    {
        IQuestionPadRepository _Repository;
        IQuestionPadService<QuestionPadViewModel> _Service;
 //#Bonsai Snippets - Declarations
        public override void SetRepositories()
        {
            _Service = new QuestionPadService<QuestionPadViewModel>((U, C, A) => 
                ExecuteQueryWithReturnTypeAndNetworkAccessAsync<QuestionPadViewModel>(U, C, A));
            _Repository = new QuestionPadRepository(_MasterRepo, _Service);
 //#Bonsai Snippets - ServicedRepos
        }
        
        public void GetCardsForID()
        {
            _Repository.GetCardsForIDAsync(InputObject);
        }

        public Func<Task> SetNavigation()
        {
            return async () =>
            {
                await _Repository.SetNavigationAsync(InputObject);
            };
        }
 //#Bonsai Snippets - Methods
    }
}