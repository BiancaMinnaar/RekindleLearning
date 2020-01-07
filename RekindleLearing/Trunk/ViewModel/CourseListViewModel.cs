using System.Collections.Generic;
using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel
{
    public class CourseListViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

       private List<CourseViewModel> courses;
        public List<CourseViewModel> Courses
        {
            get { return courses; }
            set
            {
                courses = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Courses"));
            }
        }
 //#Bonsai Snippets - Properties
    }
}