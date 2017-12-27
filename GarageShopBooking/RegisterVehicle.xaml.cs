﻿using System;
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
            txtMilage.Text = String.Empty;
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
            lblMilage.Visibility = Visibility.Hidden;
            txtMilage.Visibility = Visibility.Hidden;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (cboxVehicleType.SelectedIndex > -1)
            {
                VehicleTypes vehicleType = (VehicleTypes)Enum.Parse(typeof(VehicleTypes), cboxVehicleType.SelectedValue.ToString(), true);
                if (vehicleType == VehicleTypes.Trailer)
                {
                    vehicle = new Trailer();
                    if (!ReadRegNumber())
                        MessageBox.Show("You need to specefiy a reg number");
                    else if (!ReadOwnerName())
                        MessageBox.Show("You need to specify an owner");
                    else if (!ReadModelYear())
                        MessageBox.Show("You need to specifye a model year");
                    else if (!ReadBrand())
                        MessageBox.Show("You need to specify a brand");
                    Trailer trailer = vehicle as Trailer;
                    trailer.LiftType = ReadLiftType();
                    trailer.Tires = ReadTires();
                    vehicle = trailer;
                }
                else if (vehicleType == VehicleTypes.Car)
                {
                    vehicle = new Car();
                    if (!ReadRegNumber())
                        MessageBox.Show("You need to specefiy a reg number");
                    else if (!ReadOwnerName())
                        MessageBox.Show("You need to specify an owner");
                    else if (!ReadModelYear())
                        MessageBox.Show("You need to specifye a model year");
                    
                    Car car = vehicle as Car;
                    car.LiftType = ReadLiftType();
                    car.Tires = ReadTires();
                    car.Doors = ReadDoors();
                    car.Height = ReadHeight();
                    vehicle = car;
                    if (int.TryParse(txtMilage.Text, out int milage))
                    {
                        vehicle.Milage = milage;
                    }
                    else
                        MessageBox.Show("You forgot to specefiy the milage");
                }
                else if (vehicleType == VehicleTypes.Truck)
                {
                    vehicle = new Truck();
                    if (!ReadRegNumber())
                        MessageBox.Show("You need to specefiy a reg number");
                    else if (!ReadOwnerName())
                        MessageBox.Show("You need to specify an owner");
                    else if (!ReadModelYear())
                        MessageBox.Show("You need to specifye a model year");

                    Truck truck = vehicle as Truck;
                    truck.LiftType = ReadLiftType();
                    truck.Tires = ReadTires();
                    truck.Doors = ReadDoors();
                    truck.Height = ReadHeight();
                    vehicle = truck;
                    if (int.TryParse(txtMilage.Text, out int milage))
                    {
                        vehicle.Milage = milage;
                    }
                    else
                        MessageBox.Show("You forgot to specefiy the milage");
                }
                else if (vehicleType == VehicleTypes.TowedSled)
                {
                    vehicle = new TowedSled();
                    if (!ReadRegNumber())
                        MessageBox.Show("You need to specefiy a reg number");
                    else if (!ReadOwnerName())
                        MessageBox.Show("You need to specify an owner");
                    else if (!ReadModelYear())
                        MessageBox.Show("You need to specifye a model year");
                    TowedSled sled = vehicle as TowedSled;
                    sled.NumOfSkids = ReadNumOfSkids();
                    sled.LiftType = ReadLiftType();

                }
                else if (vehicleType == VehicleTypes.MotorCycle)
                {
                    vehicle = new MotorCycle();
                    if (!ReadRegNumber())
                        MessageBox.Show("You need to specefiy a reg number");
                    else if (!ReadOwnerName())
                        MessageBox.Show("You need to specify an owner");
                    else if (!ReadModelYear())
                        MessageBox.Show("You need to specifye a model year");

                    MotorCycle mc = vehicle as MotorCycle;
                    mc.LiftType = ReadLiftType();
                    mc.Tires = ReadTires();
                    vehicle = mc;
                    if (int.TryParse(txtMilage.Text, out int milage))
                    {
                        vehicle.Milage = milage;
                    }
                    else
                        MessageBox.Show("You forgot to specefiy the milage");
                }
                vehicle.ServiceLevel = (ServiceLevel)Enum.Parse(typeof(ServiceLevel), cboxServiceLevel.SelectedValue.ToString(), true);
                this.DialogResult = true;
            }
            else
                MessageBox.Show("You need to select a  Vehicle type");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private bool ReadOwnerName()
        {
            if (! String.IsNullOrEmpty(txtOwnerFirstName.Text) && ! String.IsNullOrEmpty(txtOwnerLastName.Text))
            {
                Owner owner = new Owner(txtOwnerFirstName.Text, txtOwnerLastName.Text);
                vehicle.Owner = owner;
                return true;
            }
            else
                return false;
        }

        private bool ReadRegNumber()
        {
            if (!String.IsNullOrEmpty(txtRegNumber.Text))
            {
                vehicle.RegNumber = txtRegNumber.Text;
                return true;
            }
            else
                return false;
        }
            
        private bool ReadModelYear()
        {
            if (! String.IsNullOrEmpty(txtModelYear.Text))
            {
                vehicle.ModelYear = txtModelYear.Text;
                return true;
            }
            else 
                return false;
        }

        private bool ReadBrand()
        {
            if (!String.IsNullOrEmpty(txtBrand.Text))
            {
                vehicle.Brand = txtBrand.Text;
                return true;
            }
            else
                return false;
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
                lblMilage.Visibility = Visibility.Hidden;
                txtMilage.Visibility = Visibility.Hidden;
                lblTires.Content = "Tires";
            }
            else if (vehicleType == VehicleTypes.Car)
            {
                txtDoors.Visibility = Visibility.Visible;
                lblDoors.Visibility = Visibility.Visible;
                lblMilage.Visibility = Visibility.Visible;
                txtMilage.Visibility = Visibility.Visible;
                lblTires.Content = "Tires";
            }
            else if (vehicleType == VehicleTypes.Truck)
            {
                lblDoors.Visibility = Visibility.Hidden;
                txtDoors.Visibility = Visibility.Hidden;
                lblMilage.Visibility = Visibility.Visible;
                txtMilage.Visibility = Visibility.Visible;
                lblTires.Content = "Tires";
            }
            else if (vehicleType == VehicleTypes.TowedSled)
            {
                txtDoors.Visibility = Visibility.Hidden;
                lblDoors.Visibility = Visibility.Hidden;
                lblMilage.Visibility = Visibility.Hidden;
                txtMilage.Visibility = Visibility.Hidden;
                lblTires.Content = "Skids";
            }
            else if (vehicleType == VehicleTypes.MotorCycle)
            {
                txtDoors.Visibility = Visibility.Hidden;
                lblDoors.Visibility = Visibility.Hidden;
                lblMilage.Visibility = Visibility.Visible;
                txtMilage.Visibility = Visibility.Visible;
                lblTires.Content = "Tires";
            }
        }
    }
}
