using System.ComponentModel;
using System.Windows.Input;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel.Control
{
    public class NoCourseSelectedButtonControlViewModel : ProjectBaseViewModel, INotifyPropertyChanged
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

        private ICommand courseListNavigation;
        public ICommand CourseListNavigation
        {
            get { return courseListNavigation; }
            set
            {
                courseListNavigation = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CourseListNavigation"));
            }
        }
        //#Bonsai Snippets - Properties
    }
}
