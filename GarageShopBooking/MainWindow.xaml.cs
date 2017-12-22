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

namespace GarageShopBooking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RegisterVehicle registerVehicle;
        GarageShop garageShop;

        public MainWindow()
        {
            InitializeComponent();
            registerVehicle = new RegisterVehicle();
            garageShop = new GarageShop();
        }

        private void btnRegisterVehicle_Click(object sender, RoutedEventArgs e)
        {
            registerVehicle.Show();
        }

        private void btnAddWorkDone_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInfoVehicle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVehicleReady_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCheckoutVehicle_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
