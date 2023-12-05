using Gestiunea_unui_hotel.Help;
using Multi_Login.Help;
using Multi_Login.Models;
using Multi_Login.Models.BusinessLogicLayer;
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
    public class RoomsVM : INotifyPropertyChanged
    {
        private Room currentCamera;
        public Room CurrentCamera
        {
            get { return this.currentCamera; }
            set
            {
                if (currentCamera == value) return;
                currentCamera = value;
                NotifyPropertyChanged("CurrentCamera");
            }
        }
        public RoomBLL roomBLL = new RoomBLL();
        public ObservableCollection<Room> Camere { get; set; }
        //public ObservableCollection<Oferta> TipuriOferte { get; set; } = new ObservableCollection<Oferta>();
        private void Add(object param)
        {
            Camere.Add(CurrentCamera);
            RoomBLL roomBLL = new RoomBLL();
            roomBLL.AddRooms(CurrentCamera);
            CurrentCamera = new Room();
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand(Add,param=>CanExecuteCommands);
                }
                return addCommand;
            }
        }
        public ObservableCollection<Oferta> OferteRezervate { get; set; } = new ObservableCollection<Oferta>();

        public bool CanExecuteCommands { get; set; } = false;

        //private Oferta selectedOferta;
        //public Oferta SelectedOferta
        //{
        //    get
        //    {
        //        return selectedOferta;
        //    }
        //    set
        //    {
        //        selectedOferta = value;
        //        if (selectedOferta != null)
        //        {
        //            CanExecuteCommands = true;
        //        }
        //        NotifyPropertyChanged("SelectOferta");
        //    }
        //}

        //private ICommand rezervaOferaCommand;
        //public ICommand RezervaOferaCommand
        //{
        //    get
        //    {
        //        if (rezervaOferaCommand == null)
        //        {
        //            rezervaOferaCommand = new RelayCommands2(Rezervare);
        //        }
        //        return rezervaOferaCommand;
        //    }
        //}

        private ICommand stergereCameraCommand;
        public ICommand StergereCameraCommand
        {
            get
            {
                if (stergereCameraCommand == null)
                {
                    stergereCameraCommand = new RelayCommand(Stergere, param => CanExecuteCommands);
                }
                return stergereCameraCommand;
            }
        }

        private void Stergere(object param)
        {
            //RoomBLL roomBLL = new RoomBLL();
            //roomBLL
            Camere.Remove(CurrentCamera);
            CurrentCamera = new Room();
        }

        private ICommand cameraCommand;
        public ICommand CameraCommand
        {
            get
            {
                if (cameraCommand == null)
                {
                    cameraCommand = new RelayCommand(Editare);
                }
                return cameraCommand;
            }
        }

        private void Editare(object param)
        {
            RoomView window = new RoomView();
            RoomViewModel signUpVM = new RoomViewModel(CurrentCamera);
            window.DataContext = signUpVM;
            App.Current.MainWindow.Close();
            App.Current.MainWindow = window;
            window.Show();

            //OfertaBLL ofertaBLL = new OfertaBLL();
            //ofertaBLL.ModifyOferta(CurrentOferta);
            //Oferte.Remove(CurrentOferta);
            //Oferte.Add(CurrentOferta);
            //CurrentOferta = new Oferta();
        }


        public RoomsVM(User user)
        {
            if (user.Type.Equals("Administrator"))
                CanExecuteCommands = true;
            Camere = roomBLL.RoomsList;
            CurrentCamera = new Room();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //RoomBLL roomBLL = new RoomBLL();
        //public RoomsViewModel()
        //{
        //    RoomsList = roomBLL.GetAllRooms();
        //}

        //#region Data Members

        //public ObservableCollection<Room> RoomsList
        //{
        //    get => roomBLL.RoomsList;
        //    set => roomBLL.RoomsList = value;
        //}
        //#endregion

        //public string ImagesPath
        //{
        //    get
        //    {
        //        return RoomsList[0].ImagesPath;
        //    }
        //}

    }
}