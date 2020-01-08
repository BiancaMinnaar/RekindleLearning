using System;
using System.Collections.Generic;
using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel.Return
{
    public class LastEdit
    {
        public string time { get; set; }
        public string timezone { get; set; }

    }
    public class AnswerList : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;
        public string id { get; set; }
        public string cardId { get; set; }
        public string correct { get; set; }
        public string position { get; set; }
        public string answer { get; set; }
        public LastEdit lastEdit { get; set; }

    }
    public class CreationDate
    {
        public string time { get; set; }
        public string timezone { get; set; }

    }
    public class CardDataModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;
        public string title { get; set; }
        public string priority { get; set; }
        public string type { get; set; }
        public string question { get; set; }
        public string questionContext { get; set; }
        public string answerContext { get; set; }
        public IList<AnswerList> answerList { get; set; }
        public LastEdit lastEdit { get; set; }
        public CreationDate creationDate { get; set; }
        public string releaseStatus { get; set; }
        public string editable { get; set; }
        public string read { get; set; }
        public string usergenerated { get; set; }

    }
}
