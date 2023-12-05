using Gestiunea_unui_hotel.Help;
using Multi_Login.Help;
using Multi_Login.Models;
using Multi_Login.Models.BusinessLogicLayer;
using Multi_Login.Models.DataAccessLayer;
using Multi_Login.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Multi_Login.ViewModels
{
    class OferteViewModel : INotifyPropertyChanged
    {

        private Oferta currentOferta;
        public Oferta CurrentOferta
        {
            get { return currentOferta; }
            set
            {
                if (currentOferta == value) return;
                currentOferta = value;
                NotifyPropertyChanged("CurrentOferta");
            }
        }
        public OfertaBLL ofertaBLL = new OfertaBLL();
        public ObservableCollection<Oferta> Oferte { get; set; }
        //public ObservableCollection<Oferta> TipuriOferte { get; set; } = new ObservableCollection<Oferta>();
        private void Add()
        {
            Oferte.Add(CurrentOferta);
            OfertaBLL ofertaBLL = new OfertaBLL();
            ofertaBLL.AddOfertaNoua(CurrentOferta);
            CurrentOferta = new Oferta();
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommands2(Add);
                }
                return addCommand;
            }
        }
        public ObservableCollection<Oferta> OferteRezervate { get; set; } = new ObservableCollection<Oferta>();

        private void Rezervare()
        {
            OferteRezervate.Add(CurrentOferta);

            RezervareOferta signInWindow = new RezervareOferta(CurrentOferta);
            RezervareOfertaViewModel signInVM = new RezervareOfertaViewModel(CurrentOferta);
            signInWindow.DataContext = signInVM;
            //App.Current.MainWindow.Close();
            App.Current.MainWindow = signInWindow;
            signInWindow.Show();

        }

        public bool CanExecuteCommands { get; set; } = false;

        private Oferta selectedOferta;
        public Oferta SelectedOferta
        {
            get
            {
                return selectedOferta;
            }
            set
            {
                selectedOferta = value;
                if (selectedOferta != null)
                {
                    CanExecuteCommands = true;
                }
                NotifyPropertyChanged("SelectOferta");
            }
        }
        private ICommand rezervaOferaCommand;
        public ICommand RezervaOferaCommand
        {
            get
            {
                if (rezervaOferaCommand == null)
                {
                    rezervaOferaCommand = new RelayCommands2(Rezervare);
                }
                return rezervaOferaCommand;
            }
        }

        private ICommand stergereOferaCommand;
        public ICommand StergereOferaCommand
        {
            get
            {
                if (stergereOferaCommand == null)
                {
                    stergereOferaCommand = new RelayCommands2(Stergere);
                }
                return stergereOferaCommand;
            }
        }

        private void Stergere()
        {
            OfertaBLL ofertaBLL = new OfertaBLL();
            ofertaBLL.DeleteOferta(CurrentOferta);
            Oferte.Remove(CurrentOferta);
            CurrentOferta = new Oferta();
        }

        private ICommand editareOferaCommand;
        public ICommand EditareOferaCommand
        {
            get
            {
                if (editareOferaCommand == null)
                {
                    editareOferaCommand = new RelayCommands2(Editare);
                }
                return editareOferaCommand;
            }
        }

        private void Editare()
        {
            OfertaBLL ofertaBLL = new OfertaBLL();
            ofertaBLL.ModifyOferta(CurrentOferta);
            //Oferte.Remove(CurrentOferta);
            //Oferte.Add(CurrentOferta);
            //CurrentOferta = new Oferta();
        }


        public OferteViewModel()
        {
            Oferte = ofertaBLL.Oferte;
            CurrentOferta = new Oferta();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
