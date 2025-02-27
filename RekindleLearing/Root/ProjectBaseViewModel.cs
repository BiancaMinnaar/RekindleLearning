using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using BaseBonsai.DataContracts;

namespace RekindleLearing.Root.ViewModel
{
    public abstract class ProjectBaseViewModel : BaseViewModel, INotifyPropertyChanged, INotifyDataErrorInfo
    {
        public bool HasErrors { get; set; }
        public IDictionary<string, string[]> LookupLists;

        public ProjectBaseViewModel()
        {
        }

        protected void SetProperty<U>(ref U backingStore, U value, string propertyName, Action onChanged = null, Action<U> onChanging = null)
        {
            if (EqualityComparer<U>.Default.Equals(backingStore, value))
                return;

            onChanging?.Invoke(value);
            OnPropertyChanging(propertyName);
            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
        }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public void OnPropertyChanging(string propertyName)
        {
            if (PropertyChanging == null)
                return;

            PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public IEnumerable GetErrors(string propertyName)
        {
            return null;
        }
    }
}