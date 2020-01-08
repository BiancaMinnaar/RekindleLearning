using System.Collections.Generic;
using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel
{
    public class QuestionPadViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        private string iD;
        public string ID
        {
            get { return iD; }
            set
            {
                iD = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ID"));
            }
        }

        private List<CardViewModel> cardList;
        public List<CardViewModel> CardList
        {
            get { return cardList; }
            set
            {
                cardList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CardList"));
            }
        }
 //#Bonsai Snippets - Properties
    }
}