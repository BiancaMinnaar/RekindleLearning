using System.ComponentModel;
using System.Windows.Input;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel
{
    public class AnswerViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

       private string answerOptionText;
        public string AnswerOptionText
        {
            get { return answerOptionText; }
            set
            {
                answerOptionText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AnswerOptionText"));
            }
        }

        private bool rememberMe;
        public bool RememberMe
        {
            get { return rememberMe; }
            set
            {
                rememberMe = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RememberMe"));
            }
        }

        private ICommand checkCommand;
        public ICommand CheckCommand
        {
            get { return checkCommand; }
            set
            {
                checkCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CheckCommand"));
            }
        }
 //#Bonsai Snippets - Properties
    }
}