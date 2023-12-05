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
    public class MenuViewModel
    {
        private User user;
        public MenuViewModel(User user)
        {
            if (user.Type.Equals("Administrator"))
            {
                CanExecuteCommandRezervari = true;
                CanExecuteCommandOferte = true;
                CanExecuteCommandClienti = true;
            }
            this.user = user;
        }
        public string Name
        {
            get
            {
                return user.Name;
            }
        }
        public string Type
        {
            get
            {
                return user.Type;
            }
        }

        public bool CanExecuteCommandRezervari { get; set; } = false;

        private ICommand rezervariCommand;
        public ICommand RezervariCommand
        {
            get
            {
                if (rezervariCommand == null)
                {
                    rezervariCommand = new RelayCommand(Rezervari, param => CanExecuteCommandRezervari);
                }
                return rezervariCommand;
            }
        }

        public void Rezervari(object param)
        {
            RezervationView signInWindow = new RezervationView();
            RezervationViewModel signInVM = new RezervationViewModel();
            signInWindow.DataContext = signInVM;
            //App.Current.MainWindow.Close();
            App.Current.MainWindow = signInWindow;
            signInWindow.Show();
        }

        public bool CanExecuteCommandRoom { get; set; } = true;

        private ICommand roomCommand;
        public ICommand RoomCommand
        {
            get
            {
                if (roomCommand == null)
                {
                    roomCommand = new RelayCommand(Camere, param => CanExecuteCommandRoom);
                }
                return roomCommand;
            }
        }

        public void Camere(object param)
        {
            RoomsView signInWindow = new RoomsView();
            RoomsVM signInVM = new RoomsVM(user);
            signInWindow.DataContext = signInVM;
            //App.Current.MainWindow.Close();
            App.Current.MainWindow = signInWindow;
            signInWindow.Show();
        }

        public bool CanExecuteCommandOferte { get; set; } = false;

        private ICommand oferteCommand;
        public ICommand OferteCommand
        {
            get
            {
                if (oferteCommand == null)
                {
                    oferteCommand = new RelayCommand(Oferte, param => CanExecuteCommandOferte);
                }
                return oferteCommand;
            }
        }

        public bool CanExecuteCommandClienti { get; set; } = false;

        private ICommand clientiCommand;
        public ICommand ClientiCommand
        {
            get
            {
                if (clientiCommand == null)
                {
                    clientiCommand = new RelayCommand(Clienti, param => CanExecuteCommandClienti);
                }
                return clientiCommand;
            }
        }
        public void Clienti(object param)
        {
            ClientsView signInWindow = new ClientsView();
            ClientsViewModel signInVM = new ClientsViewModel();
            signInWindow.DataContext = signInVM;
            //App.Current.MainWindow.Close();
            App.Current.MainWindow = signInWindow;
            signInWindow.Show();
        }

        private ICommand preturiCommand;
        public ICommand PreturiCommand
        {
            get
            {
                if (preturiCommand == null)
                {
                    preturiCommand = new RelayCommand(Preturi, param => CanExecuteCommandClienti);
                }
                return preturiCommand;
            }
        }
        public void Preturi(object param)
        {
            PreturiView signInWindow = new PreturiView();
            PreturiViewModel signInVM = new PreturiViewModel();
            signInWindow.DataContext = signInVM;
            //App.Current.MainWindow.Close();
            App.Current.MainWindow = signInWindow;
            signInWindow.Show();
        }
        public void Oferte(object param)
        {
            OferteView signInWindow = new OferteView();
            OferteViewModel signInVM = new OferteViewModel();
            signInWindow.DataContext = signInVM;
            //App.Current.MainWindow.Close();
            App.Current.MainWindow = signInWindow;
            signInWindow.Show();
        }
    }
}
