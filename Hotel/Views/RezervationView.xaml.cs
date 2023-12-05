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
    /// Interaction logic for RezervationView.xaml
    /// </summary>
    public partial class RezervationView : Window
    {
        public RezervationView()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
