using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel.Control
{
    public class LinkButtonControlViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

       private string buttonText;
        public string ButtonText
        {
            get { return buttonText; }
            set
            {
                buttonText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ButtonText"));
            }
        }

private string uRL;
        public string URL
        {
            get { return uRL; }
            set
            {
                uRL = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("URL"));
            }
        }

 //#Bonsai Snippets - Properties
    }
}
