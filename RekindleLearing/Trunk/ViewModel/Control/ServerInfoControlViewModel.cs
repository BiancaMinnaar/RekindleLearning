using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel.Control
{
    public class ServerInfoControlViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

       private string headingLabel;
        public string HeadingLabel
        {
            get { return headingLabel; }
            set
            {
                headingLabel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HeadingLabel"));
            }
        }

private string version;
        public string Version
        {
            get { return version; }
            set
            {
                version = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Version"));
            }
        }

private string build;
        public string Build
        {
            get { return build; }
            set
            {
                build = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Build"));
            }
        }

private string date;
        public string Date
        {
            get { return date; }
            set
            {
                date = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Date"));
            }
        }

 //#Bonsai Snippets - Properties
    }
}
