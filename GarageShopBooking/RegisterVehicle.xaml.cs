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

namespace GarageShopBooking
{
    /// <summary>
    /// Interaction logic for RegisterVehicle.xaml
    /// </summary>
    public partial class RegisterVehicle : Window
    {
        public RegisterVehicle()
        {
            InitializeComponent();
            this.Title = "Register vehicle";
            InitalizeGUI();
        }

        private void InitalizeGUI()
        {
            txtOwnerName.Text = String.Empty;
            txtRegNumber.Text = String.Empty;
            txtModelYear.Text = String.Empty;
            txtBrand.Text = String.Empty;
            txtLiftType.Text = String.Empty;
            txtTires.Text = String.Empty;
            txtDoors.Text = String.Empty;
            cboxServiceLevel.ItemsSource = Enum.GetValues(typeof(ServiceLevel)).Cast<ServiceLevel>();
            cboxVehicleType.ItemsSource = Enum.GetValues(typeof(VehicleTypes)).Cast<VehicleTypes>();
            txtDoors.Visibility = Visibility.Hidden;
            lblDoors.Visibility = Visibility.Hidden;
            lblLift.Visibility = Visibility.Hidden;
            txtLiftType.Visibility = Visibility.Hidden;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            VehicleTypes vehicleType = (VehicleTypes)Enum.Parse(typeof(VehicleTypes), cboxVehicleType.SelectedValue.ToString(), true);
            if (vehicleType == VehicleTypes.Trailer)
            {
                
            }
            else if (vehicleType == VehicleTypes.Car)
            {
               
            }
            else if (vehicleType == VehicleTypes.Truck)
            {
               
            }
            else if (vehicleType == VehicleTypes.TowedSled)
            {
                
            }
            else if (vehicleType == VehicleTypes.MotorCycle)
            {
                
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private bool ReadOwnerName()
        {
            if (! String.IsNullOrEmpty(txtOwnerName.Text))
            {

            }
            return false;
        }

        private void cboxVehicleType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VehicleTypes vehicleType = (VehicleTypes)Enum.Parse(typeof(VehicleTypes), cboxVehicleType.SelectedValue.ToString(), true);

            if (vehicleType == VehicleTypes.Trailer)
            {
                txtDoors.Visibility = Visibility.Hidden;
                lblDoors.Visibility = Visibility.Hidden;
                lblLift.Visibility = Visibility.Hidden;
                txtLiftType.Visibility = Visibility.Hidden;
                lblTires.Content = "Tires";
            }
            else if (vehicleType == VehicleTypes.Car)
            {
                txtDoors.Visibility = Visibility.Visible;
                lblDoors.Visibility = Visibility.Visible;
                lblLift.Visibility = Visibility.Visible;
                lblTires.Content = "Tires";
            }
            else if (vehicleType == VehicleTypes.Truck)
            {
                lblDoors.Visibility = Visibility.Hidden;
                txtDoors.Visibility = Visibility.Hidden;
                lblLift.Visibility = Visibility.Visible;
                txtLiftType.Visibility = Visibility.Visible;
                lblTires.Content = "Tires";
            }
            else if (vehicleType == VehicleTypes.TowedSled)
            {
                txtDoors.Visibility = Visibility.Hidden;
                lblDoors.Visibility = Visibility.Hidden;
                lblLift.Visibility = Visibility.Hidden;
                txtLiftType.Visibility = Visibility.Hidden;
                lblTires.Content = "Skids";
            }
            else if (vehicleType == VehicleTypes.MotorCycle)
            {
                txtDoors.Visibility = Visibility.Hidden;
                lblDoors.Visibility = Visibility.Hidden;
                lblLift.Visibility = Visibility.Hidden;
                txtLiftType.Visibility = Visibility.Hidden;
                lblTires.Content = "Tires";
            }
        }
    }
}
