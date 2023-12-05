using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Windows;
using Multi_Login.Views;
using Multi_Login.Models;
using System.Collections.ObjectModel;
using Gestiunea_unui_hotel.Help;

namespace Multi_Login.ViewModels
{
    public class SignInModel : NotifyViewModel
    {
        public SignInModel()
        {
        }
        public bool CanExecuteCommandMenu { get; set; } = true;

        private ICommand menuInCommand;
        public ICommand MenuInCommand
        {
            get
            {
                if (menuInCommand == null)
                {
                    menuInCommand = new RelayCommand(SignIn, param => CanExecuteCommandMenu);
                }
                return menuInCommand;
            }
        }

        public void SignIn(object param)
        {
            
        }
    }
}
