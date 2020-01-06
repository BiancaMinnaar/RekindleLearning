using System.ComponentModel;
using System.Windows.Input;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel.Control
{
    public class ImageButtonControlViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        private string imageName;
        public string ImageName
        {
            get { return imageName; }
            set
            {
                imageName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ImageName"));
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

        private ICommand actionCommand;
        public ICommand ActionCommand
        {
            get { return actionCommand; }
            set
            {
                actionCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ActionCommand"));
            }
        }

        //#Bonsai Snippets - Properties
    }
}
