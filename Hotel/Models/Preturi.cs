using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models
{
    public class Preturi : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Preturi()
        {
        }

        private int? id;
        private int valoare;
        private DateTime dataInceput;
        private DateTime dataFinal;
        private int cameraID;

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
        public int CameraID
        {
            get
            {
                return cameraID;
            }
            set
            {
                cameraID = value;
                NotifyPropertyChanged("CameraID");
            }
        }
        public int Valoare
        {
            get
            {
                return valoare;
            }
            set
            {
                valoare = value;
                NotifyPropertyChanged("Valoare");
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
    }
    }
