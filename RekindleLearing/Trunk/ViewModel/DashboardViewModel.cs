using System.ComponentModel;
using RekindleLearing.Root.ViewModel;
using RekindleLearing.Trunk.ViewModel.Control;

namespace RekindleLearing.Trunk.ViewModel
{
    public class DashboardViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        private CourseWideButtonControlViewModel courseWideModel;
        public CourseWideButtonControlViewModel CourseWideModel
        {
            get { return courseWideModel; }
            set
            {
                courseWideModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CourseWideModel"));
            }
        }

        private ImageButtonControlViewModel myRekindleModel;
        public ImageButtonControlViewModel MyRekindleModel
        {
            get { return myRekindleModel; }
            set
            {
                myRekindleModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MyRekindleModel"));
            }
        }

        private ImageButtonControlViewModel myCoursesModel;
        public ImageButtonControlViewModel MyCoursesModel
        {
            get { return myCoursesModel; }
            set
            {
                myCoursesModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MyCoursesModel"));
            }
        }

        private ImageButtonControlViewModel moreCoursesModel;
        public ImageButtonControlViewModel MoreCoursesModel
        {
            get { return moreCoursesModel; }
            set
            {
                moreCoursesModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MoreCoursesModel"));
            }
        }

        private ImageButtonControlViewModel knowledgeMatchModel;
        public ImageButtonControlViewModel KnowledgeMatchModel
        {
            get { return knowledgeMatchModel; }
            set
            {
                knowledgeMatchModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("KnowledgeMatchModel"));
            }
        }

       private NoCourseSelectedButtonControlViewModel noCourseWideModel;
        public NoCourseSelectedButtonControlViewModel NoCourseWideModel
        {
            get { return noCourseWideModel; }
            set
            {
                noCourseWideModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NoCourseWideModel"));
            }
        }
 //#Bonsai Snippets - Properties
        public DashboardViewModel()
        {
            CourseWideModel = new CourseWideButtonControlViewModel();
            NoCourseWideModel = new NoCourseSelectedButtonControlViewModel();
            MyRekindleModel = new ImageButtonControlViewModel
            {
                ImageName = "Person",
                Text = "My Rekindle"
            };
            MyCoursesModel = new ImageButtonControlViewModel
            {
                ImageName = "Person",
                Text = "My Courses"
            };
            MoreCoursesModel = new ImageButtonControlViewModel
            {
                ImageName = "Person",
                Text = "More Courses"
            };
            KnowledgeMatchModel = new ImageButtonControlViewModel
            {
                ImageName = "Person",
                Text = "KnowledgeMatch"
            };
        }
    }
}