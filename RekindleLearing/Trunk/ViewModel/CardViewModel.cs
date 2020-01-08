using System.Collections.Generic;
using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel
{
    public class CardViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

       private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
            }
        }
private string question;
        public string Question
        {
            get { return question; }
            set
            {
                question = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Question"));
            }
        }

        private List<AnswerViewModel> answers;
        public List<AnswerViewModel> Answers
        {
            get { return answers; }
            set
            {
                answers = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Answers"));
            }
        }
 //#Bonsai Snippets - Properties
    }
}