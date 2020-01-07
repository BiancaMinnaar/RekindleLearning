using System;
using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel
{
    public class CourseDetailsViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        private string uID;
        public string UID
        {
            get { return uID; }
            set
            {
                uID = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UID"));
            }
        }

        private byte[] courseImage;
        public byte[] CourseImage
        {
            get { return courseImage; }
            set
            {
                courseImage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CourseImage"));
            }
        }

        private string courseTitle;
        public string CourseTitle
        {
            get { return courseTitle; }
            set
            {
                courseTitle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CourseTitle"));
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
            }
        }

        private string introduction;
        public string Introduction
        {
            get { return introduction; }
            set
            {
                introduction = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Introduction"));
            }
        }

        private string lessonsCount;
        public string LessonsCount
        {
            get { return lessonsCount; }
            set
            {
                lessonsCount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LessonsCount"));
            }
        }

        private string cardsCount;
        public string CardsCount
        {
            get { return cardsCount; }
            set
            {
                cardsCount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CardsCount"));
            }
        }
 //#Bonsai Snippets - Properties
    }
}