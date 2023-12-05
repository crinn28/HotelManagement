using Multi_Login.Exceptions;
using Multi_Login.Models;
using Multi_Login.Models.DataAccessLayer;
using Multi_Login.ViewModels;
using Multi_Login.Views;
using System.Collections.ObjectModel;

namespace Multi_Login.Models
{
    public class UserBLL
    {
        public ObservableCollection<User> UsersList { get; set; }
        //public string ErrorMessage { get; set; }

        UserDAL userDAL = new UserDAL();

        public ObservableCollection<User> GetAllUsers()
        {
            return userDAL.GetAllUsers();
        }

        //public ObservableCollection<User> GetAllPersonsWithoutPhone()
        //{
        //    return persoanaDAL.GetAllPersonsWithNoPhone();
        //}

        public void AddUser(User user)
        {
            //if (string.IsNullOrEmpty(use))
            //{
            //    throw new HotelException("Numele persoanei trebuie sa fie precizat");
            //}
            userDAL.AddUser(user);

            MenuWindow menuWindow = new MenuWindow();
            MenuViewModel menuVM = new MenuViewModel(user);
            menuWindow.DataContext = menuVM;
            App.Current.MainWindow.Close();
            App.Current.MainWindow = menuWindow;
            menuWindow.Show();

            UsersList.Add(user);
        }

        //public void ModifyPerson(User persoana)
        //{
        //    if (persoana == null)
        //    {
        //        throw new HotelException("Trebuie selectata o persoana");
        //    }
        //    if (string.IsNullOrEmpty(persoana.Name))
        //    {
        //        throw new HotelException("Trebuie precizat numele persoanei");
        //    }
        //    persoanaDAL.ModifyPerson(persoana);
        //}

        public void DeletePerson(User persoana)
        {
            if (persoana == null)
            {
                //throw new AgendaException("Trebuie precizata o persoana!");
            }
            //else
            //{
            //    PhoneDAL phoneDAL = new PhoneDAL();
            //    if (phoneDAL.GetAllPhonesForPerson(persoana).Count > 0)
            //    {
            //        throw new AgendaException("Trebuie sa stergeti mai intai numerele de telefon ale persoanei!");
            //    }
            //}
           // persoanaDAL.DeletePerson(persoana);
            //PersonsList.Remove(persoana);
        }
    }
}
