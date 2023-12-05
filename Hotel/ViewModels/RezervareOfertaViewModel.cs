using Multi_Login.Help;
using Multi_Login.Models;
using Multi_Login.Models.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Multi_Login.ViewModels
{
    class RezervareOfertaViewModel : INotifyPropertyChanged
    {
        private Oferta oferta;
        private string nameTextBox;

        public string NameTextBox
        {
            get
            {
                return nameTextBox;
            }
            set
            {
                nameTextBox = value;
                NotifyPropertyChanged("NameTextBox");
            }
        }

        private string emailTextBox;

        public string EmailTextBox
        {
            get
            {
                return emailTextBox;
            }
            set
            {
                emailTextBox = value;
                NotifyPropertyChanged("EmailTextBox");
            }
        }


        private ICommand rezervaCommand;
        public ICommand RezervaCommand
        {
            get
            {
                if (rezervaCommand == null)
                {
                    rezervaCommand = new RelayCommands2(Rezervare);
                }
                return rezervaCommand;
            }
        }

        private void Rezervare()
        {
            OfertaBLL ofertaBLL = new OfertaBLL();
            ofertaBLL.AddOferta(this.oferta,NameTextBox,EmailTextBox);
        }

        public RezervareOfertaViewModel(Oferta oferta)
        {
            this.oferta = oferta;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
