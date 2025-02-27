using System.ComponentModel;
using System.Windows.Input;
using RekindleLearing.Root.ViewModel;

namespace RekindleLearing.Trunk.ViewModel
{
    public class UserViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

       private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserName"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
            }
        }
        private ICommand loginFunction;
        public ICommand LoginFunction
        {
            get { return loginFunction; }
            set
            {
                loginFunction = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoginFunction"));
            }
        }

        private ICommand resetPasswordFunction;
        public ICommand ResetPasswordFunction
        {
            get { return resetPasswordFunction; }
            set
            {
                resetPasswordFunction = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ResetPasswordFunction"));
            }
        }
private bool isLoggedIn;
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set
            {
                isLoggedIn = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsLoggedIn"));
            }
        }
 //#Bonsai Snippets - Properties
    }
}