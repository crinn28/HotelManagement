using Multi_Login.Models;
using Multi_Login.Models.BusinessLogicLayer;
using Multi_Login.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Multi_Login.Views
{
    /// <summary>
    /// Interaction logic for RoomsView.xaml
    /// </summary>
    public partial class RoomsView : Window
    {
        RoomBLL roomBLL = new RoomBLL();
        public RoomsView()
        {
            InitializeComponent();
            RoomsList = roomBLL.GetAllRooms();
        }

        #region Data Members

        public ObservableCollection<Room> RoomsList
        {
            get => roomBLL.RoomsList;
            set => roomBLL.RoomsList = value;
        }
        #endregion

        public string ImagesPath
        {
            get
            {
                return RoomsList[0].ImagesPath;
            }
        }

        private void Method(int index)
        {
            RoomView signInWindow = new RoomView();
            RoomViewModel signInVM = new RoomViewModel(RoomsList[index]);
            signInWindow.DataContext = signInVM;
            //App.Current.MainWindow.Close();
            App.Current.MainWindow = signInWindow;
            signInWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Method(0);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Method(1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Method(2);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Method(3);
        }
    }
}
