using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models
{
    public class Room: INotifyPropertyChanged
    { 
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Room()
        {
        }

        private int? id;
        private int nrCamere;
        private string tipul;
        private string imagesPath;
        private string pretID;
        private bool tv;
        private bool balcon;
        private bool miniBar;
        private bool aerConditionat;

        public bool TV
        {
            get
            {
                return tv;
            }
            set
            {
                tv = value;
                NotifyPropertyChanged("TV");
            }
        }

        public bool Balcon
        {
            get
            {
                return balcon;
            }
            set
            {
                balcon = value;
                NotifyPropertyChanged("Balcon");
            }
        }

        public bool MiniBar
        {
            get
            {
                return miniBar;
            }
            set
            {
                miniBar = value;
                NotifyPropertyChanged("MiniBar");
            }
        }

        public bool AerConditionat
        {
            get
            {
                return aerConditionat;
            }
            set
            {
                aerConditionat = value;
                NotifyPropertyChanged("AerConditionat");
            }
        }

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

        public int NrCamere
        {
            get
            {
                return nrCamere;
            }
            set
            {
                nrCamere = value;
                NotifyPropertyChanged("NrCamere");
            }
        }

        public string Tipul
        {
            get
            {
                return tipul;
            }
            set
            {
                tipul = value;
                NotifyPropertyChanged("Tipul");
            }
        }

        public string ImagesPath
        {
            get
            {
                return imagesPath;
            }
            set
            {
                imagesPath = value;
                NotifyPropertyChanged("ImagesPath");
            }
        }

        public string PretID
        {
            get
            {
                return pretID;
            }
            set
            {
                pretID = value;
                NotifyPropertyChanged("PretID");
            }
        }

    }
}
