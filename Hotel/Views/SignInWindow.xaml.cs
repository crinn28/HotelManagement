using Multi_Login.Models;
using Multi_Login.Models.DataAccessLayer;
using Multi_Login.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    /// 

    public partial class SignInWindow : Window
    {
        //public SignInWindow()
        //{
        //    InitializeComponent();
        //}
        private Users users;
        public SignInWindow()
        {
            InitializeComponent();
            users = new Users();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            bool ok = false;
            UserBLL userBll = new UserBLL();
            foreach (User user in userBll.GetAllUsers())
            {
                if(user.Name.Equals(txtUsername.Text.ToString()))
                {
                    ok = true;
                    if(user.Password.Equals(txtPassword.Password.ToString()))
                    {
                        MenuWindow menuWindow = new MenuWindow();
                        MenuViewModel menuVM = new MenuViewModel(user);
                        menuWindow.DataContext = menuVM;
                        App.Current.MainWindow.Close();
                        App.Current.MainWindow = menuWindow;
                        menuWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Parola este incorecta!");
                    }
                }
            }
            if (ok == false)
            {
                MessageBox.Show("Numele de utilizator este incorect!");
            }
        }

        //private bool VerifyUser(string username, string password)
        //{
            //con.Open();
            //com.Connection = con;
            //com.CommandText = "select Status from Users where username='" + username + "' and password='" + password + "'";
            //dr = com.ExecuteReader();
            //if (dr.Read())
            //{
            //    if (Convert.ToBoolean(dr["Status"]) == true)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    return false;
            //}
        //}
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //private void btnExit_Click(object sender, RoutedEventArgs e)
        //{
        //    Application.Current.Shutdown();
        //}

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        //private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        //private void btnLogin_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show(txtUsername.Text.ToString(), txtPassword.Password, MessageBoxButton.OK, MessageBoxImage.Information);
        //}
    }
}
