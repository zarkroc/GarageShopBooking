using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GarageShopBooking
{
    /// <summary>
    /// Interaction logic for RegisterVehicle.xaml
    /// </summary>
    public partial class RegisterVehicle : Window
    {
        Vehicle vehicle;
        VehicleTypes vehicleType;

        internal Vehicle Vehicle { get => vehicle; }

        public RegisterVehicle()
        {
            InitializeComponent();
            this.Title = "Register vehicle";
            InitalizeGUI();
        }

        private void InitalizeGUI()
        {
            txtOwnerFirstName.Text = String.Empty;
            txtOwnerLastName.Text = String.Empty;
            txtRegNumber.Text = String.Empty;
            txtModelYear.Text = String.Empty;
            txtBrand.Text = String.Empty;
            txtTires.Text = String.Empty;
            txtDoors.Text = String.Empty;
            cboxServiceLevel.ItemsSource = Enum.GetValues(typeof(ServiceLevel)).Cast<ServiceLevel>();
            cboxVehicleType.ItemsSource = Enum.GetValues(typeof(VehicleTypes)).Cast<VehicleTypes>();
            cboxLiftType.ItemsSource = Enum.GetValues(typeof(LiftType)).Cast<LiftType>();
            txtDoors.Visibility = Visibility.Hidden;
            lblDoors.Visibility = Visibility.Hidden;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            VehicleTypes vehicleType = (VehicleTypes)Enum.Parse(typeof(VehicleTypes), cboxVehicleType.SelectedValue.ToString(), true);
            if (vehicleType == VehicleTypes.Trailer)
            {
                vehicle = new Trailer(ReadRegNumber(), ReadBrand(), ReadModelYear(), ReadOwnerName(), ReadTires(), ReadLiftType());
            }
            else if (vehicleType == VehicleTypes.Car)
            {
                vehicle = new Car(ReadRegNumber(), ReadBrand(), ReadModelYear(), ReadOwnerName(), ReadDoors(), ReadTires(), ReadLiftType(), ReadHeight());
            }
            else if (vehicleType == VehicleTypes.Truck)
            {
                vehicle = new Truck(ReadRegNumber(), ReadBrand(), ReadModelYear(), ReadOwnerName(), ReadDoors(), ReadTires(), ReadLiftType(), ReadHeight());
            }
            else if (vehicleType == VehicleTypes.TowedSled)
            {
                vehicle = new TowedSled(ReadRegNumber(), ReadBrand(), ReadModelYear(), ReadOwnerName(), ReadNumOfSkids(), ReadLiftType());
            }
            else if (vehicleType == VehicleTypes.MotorCycle)
            {
                vehicle = new MotorCycle(ReadRegNumber(), ReadBrand(), ReadModelYear(), ReadOwnerName(), ReadTires(), ReadLiftType(), ReadHeight());
            }

            vehicle.ServiceLevel = (ServiceLevel)Enum.Parse(typeof(ServiceLevel), cboxServiceLevel.SelectedValue.ToString(), true);

            this.DialogResult = true;
            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private Owner ReadOwnerName()
        {
            if (! String.IsNullOrEmpty(txtOwnerFirstName.Text) && ! String.IsNullOrEmpty(txtOwnerLastName.Text))
            {
                return new Owner(txtOwnerFirstName.Text, txtOwnerLastName.Text);
            }
            else
                return null;
        }

        private string ReadRegNumber()
        {
            if (! String.IsNullOrEmpty(txtRegNumber.Text))
            {
                return txtRegNumber.Text;
            }
            else
                return null;
        }
            
        private string ReadModelYear()
        {
            if (! String.IsNullOrEmpty(txtModelYear.Text))
            {
                return txtModelYear.Text;
            }
            else 
                return null;
        }

        private string ReadBrand()
        {
            if (!String.IsNullOrEmpty(txtBrand.Text))
            {
                return txtBrand.Text;
            }
            else
                return null;
        }

        private int ReadTires()
        {
            if (int.TryParse(txtTires.Text, out int numTires))
            {
                return numTires;
            }
            else
                return -1;
        }

        private LiftType ReadLiftType()
        {
            if (cboxLiftType.SelectedIndex >= 0)
            {
                return (LiftType)Enum.Parse(typeof(LiftType), cboxLiftType.SelectedValue.ToString(), true);
            }
            else
                return LiftType.Heavy;
        }

        private int ReadNumOfSkids()
        {
            if (int.TryParse(txtTires.Text, out int numSkids))
            {
                return numSkids;
            }
            else
                return -1;
        }

        private int ReadDoors()
        {
            if (int.TryParse(txtTires.Text, out int numDoors))
            {
                return numDoors;
            }
            else
                return -1;
        }

        /// <summary>
        /// Hard coded for now.
        /// </summary>
        /// <returns></returns>
        private double ReadHeight()
        {
            if (vehicleType == VehicleTypes.Car)
                return 2.0;
            else if (vehicleType == VehicleTypes.Truck)
                return 4.0;
            else 
                return 1.5;
        }

        private void cboxVehicleType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vehicleType = (VehicleTypes)Enum.Parse(typeof(VehicleTypes), cboxVehicleType.SelectedValue.ToString(), true);

            if (vehicleType == VehicleTypes.Trailer)
            {
                txtDoors.Visibility = Visibility.Hidden;
                lblDoors.Visibility = Visibility.Hidden;
                lblTires.Content = "Tires";
            }
            else if (vehicleType == VehicleTypes.Car)
            {
                txtDoors.Visibility = Visibility.Visible;
                lblDoors.Visibility = Visibility.Visible;
                lblTires.Content = "Tires";
            }
            else if (vehicleType == VehicleTypes.Truck)
            {
                lblDoors.Visibility = Visibility.Hidden;
                txtDoors.Visibility = Visibility.Hidden;
                lblTires.Content = "Tires";
            }
            else if (vehicleType == VehicleTypes.TowedSled)
            {
                txtDoors.Visibility = Visibility.Hidden;
                lblDoors.Visibility = Visibility.Hidden;
                lblTires.Content = "Skids";
            }
            else if (vehicleType == VehicleTypes.MotorCycle)
            {
                txtDoors.Visibility = Visibility.Hidden;
                lblDoors.Visibility = Visibility.Hidden;
                lblTires.Content = "Tires";
            }
        }
    }
}
