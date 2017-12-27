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
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            lstReadyVehicles.Items.Clear();
            lstVehicles.Items.Clear();
        }
        private void UpdateGUI()
        {
            lstReadyVehicles.Items.Clear();
            lstVehicles.Items.Clear();
            foreach (Vehicle vehicle in garageShop.RepairObjects)
            {
                lstVehicles.Items.Add(vehicle.ToString());
            }
            foreach (Vehicle vehicle in garageShop.ReadyObjects)
            {
                lstReadyVehicles.Items.Add(vehicle.ToString());
            }
        }

        private void btnRegisterVehicle_Click(object sender, RoutedEventArgs e)
        {
            registerVehicle = new RegisterVehicle();
            registerVehicle.ShowDialog();
            if (registerVehicle.DialogResult.HasValue && registerVehicle.DialogResult.Value)
            {
                garageShop.AddVehicle(registerVehicle.Vehicle);
                UpdateGUI();
            }
            
        }

        private void btnAddWorkDone_Click(object sender, RoutedEventArgs e)
        {
            if (lstVehicles.SelectedIndex >= 0)
            {
                string extraWork = Microsoft.VisualBasic.Interaction.InputBox("What is the cost of the extra work?", "Extra work", "");
                if (int.TryParse(extraWork, out int price))
                {
                    garageShop.RepairObjects[lstVehicles.SelectedIndex].AddWork(price);
                }
                else
                    MessageBox.Show("Failed to parse input to numbers");
            }
            else
                MessageBox.Show("No vehicle selected");
            
        }

        /// <summary>
        /// Use a Visual Basic component instead of creating a new WPF form to handle the input message box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoVehicle_Click(object sender, RoutedEventArgs e)
        {
            string regNumber = Microsoft.VisualBasic.Interaction.InputBox("Search reg Number?", "Search vehicle", "");
            Vehicle vehicle = garageShop.SearchVehicle(regNumber);
            if (vehicle == null)
                MessageBox.Show("No vehicle found");
            else
                MessageBox.Show(vehicle.ToString());
        }

        private void btnVehicleReady_Click(object sender, RoutedEventArgs e)
        {
            if (lstVehicles.SelectedIndex >= 0)
            {
                garageShop.VehicleReady(lstVehicles.SelectedIndex);
                UpdateGUI();
            }
            else
                MessageBox.Show("No vehicle selected");
        }

        private void btnCheckoutVehicle_Click(object sender, RoutedEventArgs e)
        {
            if (lstReadyVehicles.SelectedIndex >= 0)
            {
                MessageBox.Show("The price for repairs is : " + garageShop.CheckOutVehicle(lstReadyVehicles.SelectedIndex));
                UpdateGUI();
            }
            else
                MessageBox.Show("No vehicle selected");
        }
    }
}
