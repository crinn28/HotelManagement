using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models
{
    public class User : INotifyPropertyChanged
    { 
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public User()
        {
        }

        public User(string name, string password, string type)
        {
            Name = name;
            Password = password;
            Type = type;
            Activ = true;
        }

        public User(string name, string type)
        {
            Name = name;
            Type = type;
        }

        private int? id;
        private string name;
        private string password;
        private string type;
        private bool activ=true;

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

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                NotifyPropertyChanged("Type");
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
