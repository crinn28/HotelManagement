using Multi_Login.Models;
using Multi_Login.Models.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.ViewModels
{
    public class PreturiViewModel : INotifyPropertyChanged
    {
        public PreturiBLL preturiBLL = new PreturiBLL();
        public ObservableCollection<Preturi> Preturi { get; set; }
        public PreturiViewModel()
        {
            Preturi = preturiBLL.Preturi;
        }
        private int valoare;
        private DateTime dataInceput;
        private DateTime dataFinal;
        private int cameraID;
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
