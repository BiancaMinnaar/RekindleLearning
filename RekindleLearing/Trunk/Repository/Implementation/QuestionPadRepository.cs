using System.Threading.Tasks;
using RekindleLearing.Root.Repository;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;
using System;
using System.Linq;

namespace RekindleLearing.Implementation.Repository
{
    public class QuestionPadRepository : ProjectBaseRepository, IQuestionPadRepository
    {
        IQuestionPadService<QuestionPadViewModel> _Service;
        
        public QuestionPadRepository(IMasterRepository masterRepository, IQuestionPadService<QuestionPadViewModel> service)
            : base(masterRepository)
        {
            _Service = service;
        }
        
        public void GetCardsForIDAsync(QuestionPadViewModel model)
        {
            model.CardList = _MasterRepo.DataSource.CourseList.FirstOrDefault(a => a.Uid.Equals(model.ID)).Cards;
        } //#Bonsai Snippets - MethodDefinitions
    }
}