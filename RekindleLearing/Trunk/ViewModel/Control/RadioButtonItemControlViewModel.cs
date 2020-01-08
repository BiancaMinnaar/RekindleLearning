using System.ComponentModel;
using System.Windows.Input;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel.Control
{
    public class RadioButtonItemControlViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

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

private string text;
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
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
