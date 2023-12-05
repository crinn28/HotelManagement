using Multi_Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Gestiunea_unui_hotel.Help;
using System.Collections.ObjectModel;
using Multi_Login.Help;
using Multi_Login.Views;

namespace Multi_Login.ViewModels
{
    public class SignUpViewModel
    {
        UserBLL userBLL = new UserBLL();
        public SignUpViewModel()
        {
            UsersList = userBLL.GetAllUsers();
        }

        #region Data Members

        public ObservableCollection<User> UsersList
        {
            get => userBLL.UsersList;
            set => userBLL.UsersList = value;
        }

        #endregion

        #region Command Members
        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommandT<User>(userBLL.AddUser);
                }
                return addCommand;
            }
        }
        #endregion
    }
}
