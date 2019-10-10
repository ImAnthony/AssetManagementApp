using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for CheckOutItem.xaml
    /// </summary>
    public partial class CheckOutItem : Page
    {
        public CheckOutItem()
        {
            InitializeComponent();
        }

        private void getInfo(object sender, RoutedEventArgs e)
        {
            string uName = userName.Text;
            System.Diagnostics.Debug.WriteLine(uName);
        }
        
    }
}
