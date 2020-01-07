using System.Threading.Tasks;
using RekindleLearing.Trunk.ViewModel;

namespace RekindleLearing.Interface.Repository
{
    public interface IQuestionPadRepository
    {
       void GetCardsForIDAsync(QuestionPadViewModel model);
 //#Bonsai Snippets - MethodInterfaces
    }
}
