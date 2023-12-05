using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models
{
    public class Dotari : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

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

    }
}
