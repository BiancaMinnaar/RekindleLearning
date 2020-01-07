using System;
using System.Collections.Generic;
using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel
{
    public class CourseViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

       private Guid uid;
        public Guid Uid
        {
            get { return uid; }
            set
            {
                uid = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Uid"));
            }
        }
private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
            }
        }
private List<string> lessons;
        public List<string> Lessons
        {
            get { return lessons; }
            set
            {
                lessons = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lessons"));
            }
        }
private List<CardDataModel> cards;
        public List<CardDataModel> Cards
        {
            get { return cards; }
            set
            {
                cards = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cards"));
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
private byte[] courseVideo;
        public byte[] CourseVideo
        {
            get { return courseVideo; }
            set
            {
                courseVideo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CourseVideo"));
            }
        }
 //#Bonsai Snippets - Properties
    }
}