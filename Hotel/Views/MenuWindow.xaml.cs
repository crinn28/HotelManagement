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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {

            InitializeComponent();

            //usernameLabel.Content = GestaoHotel.getUsername();

            //Router.Children.Add(new Home());

        }

        private void MouseEvent_DragWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void MouseEvent_CloseWindow(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MouseEvent_MinimizeWindow(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void dashHome(object sender, RoutedEventArgs e)
        {
            Router.Children.Clear();
            //Router.Children.Add(new Home());
        }

        private void dashReservas(object sender, RoutedEventArgs e)
        {
            Router.Children.Clear();
            //Router.Children.Add(new Reservas());
        }

        private void dashClientes(object sender, RoutedEventArgs e)
        {
            Router.Children.Clear();
            //Router.Children.Add(new Clientes());
        }

        private void dashQuartos(object sender, RoutedEventArgs e)
        {
            Router.Children.Clear();
            //Router.Children.Add(new Quartos());
        }

        private void dashConsumos(object sender, RoutedEventArgs e)
        {
            Router.Children.Clear();
            //Router.Children.Add(new Consumos());
        }

        private void dashDefinicoes(object sender, RoutedEventArgs e)
        {
            Router.Children.Clear();
            //Router.Children.Add(new Definicoes());
        }

        private void dashFaturas(object sender, RoutedEventArgs e)
        {
            Router.Children.Clear();
            //Router.Children.Add(new Faturas());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
