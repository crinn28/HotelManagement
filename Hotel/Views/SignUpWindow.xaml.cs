using Multi_Login.Models;
using Multi_Login.ViewModels;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        public void MethodName()
        {
            if (txtPassword.Password.Equals(txtPassword2.Text))
            {
                //Common Ocommon = new Common();
                //User user = new User(txtUsername.Text, txtPassword.Password, txtType.Text);
                //MenuWindow menuWindow = new MenuWindow();
                //MenuViewModel menuVM = new MenuViewModel(user);
                //menuWindow.DataContext = menuVM;
                //App.Current.MainWindow.Close();
                //App.Current.MainWindow = menuWindow;
                //menuWindow.Show();
                //Ocommon.Test(user);
                //MessageBox.Show("Insert Successfully...");
            }
            else
            {
                MessageBox.Show("Parolele nu coincid!");
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MethodName();
        }
    }
}
