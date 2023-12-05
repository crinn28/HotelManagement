using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models
{
    public class Clienti : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Clienti()
        {
        }

        public Clienti(string name, string email, bool activ)
        {
            Name = name;
            Email = email;
            Activ = true;
        }

        private int? id;
        private string name;
        private string email;
        private bool activ = true;

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

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                NotifyPropertyChanged("PasEmailsword");
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
    }
}
