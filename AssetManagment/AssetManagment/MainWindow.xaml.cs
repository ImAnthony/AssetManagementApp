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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AssetManagment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickCheckout(object sender, RoutedEventArgs e)
        {
            Main.Content = new CheckOutItem();
        }

        private void ReturnAnItem(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page1();
        }

        private void SearchForUser(object sender, RoutedEventArgs e)
        {

        }

        private void AddNewConsumable(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveItemFromList(object sender, RoutedEventArgs e)
        {

        }
    }
}
