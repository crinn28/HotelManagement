using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models
{
    public class Oferta : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int? id;
        private int tipCamera;
        private string pret;
        private string nume;
        private DateTime dataInceput;
        private DateTime dataFinal;
        private bool activ=true;
        private bool spa;
        private bool accesAqua;
        private bool micDejun;
        public int? ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                NotifyPropertyChanged("ID");
            }
        }

        public bool Activ
        {
            get
            {
                return activ;
            }
            set
            {
                activ = value;
                NotifyPropertyChanged("Activ");
            }
        }

        public bool Spa
        {
            get
            {
                return spa;
            }
            set
            {
                spa = value;
                NotifyPropertyChanged("Spa");
            }
        }

        public bool AccesAqua
        {
            get
            {
                return accesAqua;
            }
            set
            {
                accesAqua = value;
                NotifyPropertyChanged("AccesAqua");
            }
        }

        public bool MicDejun
        {
            get
            {
                return micDejun;
            }
            set
            {
                micDejun = value;
                NotifyPropertyChanged("MicDejun");
            }
        }

        public DateTime DataInceput
        {
            get
            {
                return dataInceput;
            }
            set
            {
                dataInceput = value;
                NotifyPropertyChanged("DataInceput");
            }
        }

        public DateTime DataFinal
        {
            get
            {
                return dataFinal;
            }
            set
            {
                dataFinal = value;
                NotifyPropertyChanged("DataFinal");
            }
        }

        public int TipCamera
        {
            get
            {
                return tipCamera;
            }
            set
            {
                tipCamera = value;
                NotifyPropertyChanged("TipCamera");
            }
        }

        public string Pret
        {
            get
            {
                return pret;
            }
            set
            {
                pret = value;
                NotifyPropertyChanged("Pret");
            }
        }

        public string Nume
        {
            get
            {
                return nume;
            }
            set
            {
                nume = value;
                NotifyPropertyChanged("Nume");
            }
        }

    }
}
