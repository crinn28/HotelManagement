using Multi_Login.Models;
using Multi_Login.Models.BusinessLogicLayer;
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
    /// Interaction logic for OferteView.xaml
    /// </summary>
    public partial class OferteView : Window
    {
        public OferteView()
        {
            InitializeComponent();
            //OfertaBLL ofertaBLL = new OfertaBLL();
            //DataContext = OfertaBLL;
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (DataContext as OfertaBLL).SelectedOferta = (sender as ListBox).SelectedItem as Oferta;
        }
    }
}
