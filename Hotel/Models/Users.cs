using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models
{
    public class Users
    {
        UserBLL userBLL = new UserBLL();
        public Users()
        {
            UsersList = userBLL.GetAllUsers();
        }
        public ObservableCollection<User> UsersList
        {
            get => userBLL.UsersList;
            set => userBLL.UsersList = value;
        }
        //public ObservableCollection<User> List { get; set; } = new ObservableCollection<User>();
    }
}
