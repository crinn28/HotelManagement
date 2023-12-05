using Gestiunea_unui_hotel.Help;
using Multi_Login.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Multi_Login.ViewModels
{
    public class RoomViewModel : NotifyViewModel
    {
        string[] filePaths;
        int index_ = 0;
        public RoomViewModel(Room room)
        {
            filePaths = Directory.GetFiles(room.ImagesPath);
            ImageSource = filePaths[index_];
            PretTextBlock = room.NrCamere;

            string dotare="";
            if (room.TV == true)
                dotare += "TV\n";
            if (room.Balcon == true)
                dotare += "Balcon\n";
            if (room.MiniBar == true)
                dotare += "Mini Bar\n";
            if (room.AerConditionat == true)
                dotare += "Aer Conditionat\n";
            Dotari = dotare;

            //editMode = true;
            //userOldName = user.Name;
            //this.users = users;
        }

        private string imageSource;
        public string ImageSource
        {
            get
            {
                return imageSource;
            }
            set
            {
                imageSource = value;
                //if (editMode)
                //{
                //    CanExecuteCommandSignIn = Validators.CanExecutePlay(NameTextBox);
                //}
                //CanExecuteCommandNext = Validators.CanExecuteNext(imageSource, images);
                //CanExecuteCommandPrev = Validators.CanExecutePrev(imageSource, images);
                NotifyPropertyChanged("ImageSource");
            }
        }

        private ICommand nextCommand;
        public ICommand NextCommand
        {
            get
            {
                if (nextCommand == null)
                {
                    nextCommand = new RelayCommand(NextMethod);
                }
                return nextCommand;
            }
        }

        public void NextMethod(object param)
        {
            int index = index_;
            if (index < filePaths.Length-1)
            {
                ImageSource = filePaths[++index];
            }
            index_++;
        }

        private ICommand prevCommand;
        public ICommand PrevCommand
        {
            get
            {
                if (prevCommand == null)
                {
                    prevCommand = new RelayCommand(PrevMethod);
                }
                return prevCommand;
            }
        }

        public void PrevMethod(object param)
        {
            int index = index_;
            if (index > 0)
            {
                ImageSource = filePaths[--index];
            }
            index_--;
        }

        private string dotari;

        public string Dotari
        {
            get
            {
                return dotari;
            }
            set
            {
                dotari = value;
                NotifyPropertyChanged("Dotari");
            }
        }

        private int pretTextBlock;

        public int PretTextBlock
        {
            get
            {
                return pretTextBlock;
            }
            set
            {
                pretTextBlock = value;
                NotifyPropertyChanged("PretTextBlock");
            }
        }
    }
}
