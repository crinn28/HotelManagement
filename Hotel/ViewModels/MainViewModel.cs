using Gestiunea_unui_hotel.Help;
using Multi_Login.Models;
using Multi_Login.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Multi_Login.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {

        }

        public bool CanExecuteCommandSignIn { get; set; } = true;

        private ICommand signInCommand;
        public ICommand SignInCommand
        {
            get
            {
                if (signInCommand == null)
                { 
                    signInCommand = new RelayCommand(SignIn, param => CanExecuteCommandSignIn);
                }
                return signInCommand;
            }
        }

        public void SignIn(object param)
        {
            SignInWindow signInWindow = new SignInWindow();
            SignInModel signInVM = new SignInModel();
            signInWindow.DataContext = signInVM;
            App.Current.MainWindow.Close();
            App.Current.MainWindow = signInWindow;
            signInWindow.Show();
        }

        private ICommand guestCommand;
        public ICommand GuestCommand
        {
            get
            {
                if (guestCommand == null)
                {
                    guestCommand = new RelayCommand(Guest);
                }
                return guestCommand;
            }
        }

        public void Guest(object param)
        {
            User user = new User("Vizitator", "Neautentificat");
            MenuWindow menuWindow = new MenuWindow();
            MenuViewModel menuVM = new MenuViewModel(user);
            menuWindow.DataContext = menuVM;
            App.Current.MainWindow.Close();
            App.Current.MainWindow = menuWindow;
            menuWindow.Show();
        }

        private ICommand signUpCommand;
        public ICommand SignUpCommand
        {
            get
            {
                if (signUpCommand == null)
                {
                    signUpCommand = new RelayCommand(SignUp);
                }
                return signUpCommand;
            }
        }

        public void SignUp(object param)
        {
            SignUpWindow window = new SignUpWindow();
            SignUpViewModel signUpVM = new SignUpViewModel();
            window.DataContext = signUpVM;
            App.Current.MainWindow.Close();
            App.Current.MainWindow = window;
            window.Show();
        }

        private ICommand exitCommand;
        public ICommand ExitCommand
        {
            get
            {
                if (exitCommand == null)
                {
                    exitCommand = new RelayCommand(Exit);
                }
                return exitCommand;
            }
        }

        public void Exit(object param)
        {
            App.Current.MainWindow.Close();
            App.Current.Shutdown();
        }
    }
}
