using System.Windows.Input;
using Xamarin.Forms;

namespace WIScheduler.UIScheduler.ViewModels.User
{
    public class UserLoginViewModel : BaseViewModel
    {
        private string _userName;
        public string UserName 
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; OnPropertyChanged(); }
        }


        public ICommand LogInCommand { private set; get; }

        public UserLoginViewModel()
        {
            LogInCommand = new Command(LoginUser);
        }

        private void LoginUser()
        {
            if( !string.IsNullOrWhiteSpace(_userName) && !string.IsNullOrWhiteSpace(_password) )
            {
                Message = "Correcto";
            }
            else
            {
                Message = "Usuario o contraseña son requeridos";
            }
        }
    }
}
