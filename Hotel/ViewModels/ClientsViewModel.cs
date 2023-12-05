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
    public class ClientsViewModel : INotifyPropertyChanged
    {
        public ClientiBLL clientiBLL = new ClientiBLL();
        public ObservableCollection<Clienti> Clienti { get; set; }
        public ClientsViewModel()
        {
            Clienti = clientiBLL.Clienti;
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string email;

        public string Emai
        {
            get
            {
                return email;
            }
            set
            {
                email= value;
                NotifyPropertyChanged("Email");
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
