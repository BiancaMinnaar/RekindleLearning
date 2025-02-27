using System.Collections.Generic;
using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel.Control
{
    public class RadioButtonQuestionControlViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        private CardViewModel questionCard;
        public CardViewModel QuestionCard
        {
            get { return questionCard; }
            set
            {
                questionCard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuestionCard"));
            }
        }

        //#Bonsai Snippets - Properties
    }
}
