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
            var cards = from card in
                            _MasterRepo.DataSource.CourseList.FirstOrDefault(a => a.Uid.ToString().Equals(model.ID)).Cards
                        select new CardViewModel
                        {
                            Title = card.title,
                            Question = card.question,
                            Answers = (from answer in card.answerList
                                      select new AnswerViewModel
                                      {
                                          AnswerOptionText = answer.answer
                                      }).ToList()
                        };
            model.CardList = cards.ToList();
        }

        public async Task SetNavigationAsync(QuestionPadViewModel model)
        {
            var yourData = new QuestionPadViewModel
            {
                //#Bonsai Snippets - Projection
            };
        } //#Bonsai Snippets - MethodDefinitions
    }
}