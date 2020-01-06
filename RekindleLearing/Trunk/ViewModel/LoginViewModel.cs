using System.ComponentModel;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel
{
    public class LoginViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        private UserViewModel loginModel;
        public UserViewModel LoginModel
        {
            get { return loginModel; }
            set
            {
                loginModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoginModel"));
            }
        }

        //#Bonsai Snippets - Properties

        public LoginViewModel()
        {
            LoginModel = new UserViewModel();
        }   
    }
}