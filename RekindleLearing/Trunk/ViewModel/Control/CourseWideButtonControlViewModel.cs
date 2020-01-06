using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel.Control
{
    public class CourseWideButtonControlViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        private bool isVisible;
        public bool IsVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsVisible"));
            }
        }
        //#Bonsai Snippets - Properties
    }
}
