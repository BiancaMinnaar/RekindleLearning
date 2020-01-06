using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel.Control
{
    public class ClientInfoControlViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;
       
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

        private string iOSVesrion;
        public string IOSVesrion
        {
            get { return iOSVesrion; }
            set
            {
                iOSVesrion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IOSVesrion"));
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
