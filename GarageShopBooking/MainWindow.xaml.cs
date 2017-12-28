using System.Windows;
/// <summary>
/// Author: Tomas Perers
/// Date: 2017-12-28
/// </summary>
namespace GarageShopBooking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RegisterVehicle registerVehicle;
        GarageShop garageShop;

        /// <summary>
        /// Create a new RegisterVehicle and GarageShop object.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            registerVehicle = new RegisterVehicle();
            garageShop = new GarageShop();
            garageShop.RestoreLists();
            InitializeGUI();
            UpdateGUI();
        }

        /// <summary>
        /// Clear the interface.
        /// </summary>
        private void InitializeGUI()
        {
            lstReadyVehicles.Items.Clear();
            lstVehicles.Items.Clear();
        }

        /// <summary>
        /// Update the both lists with information about registered vehicles.
        /// </summary>
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

        /// <summary>
        /// Add a vehicle when button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Add extra cost for work done when button is clicked.
        /// Use a VisualBasic input box.
        /// TODO: Implement a prettier window and add what work has been performed as well.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// TODO: Make a prettier window to handle the search function. Perhaps even an option to search on owner name as well?
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

        /// <summary>
        /// Move the selected vehicle to the list of ready vehicles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Checkout and display the price for work that has been done on the car.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void Window_Closing(object sender, System.EventArgs e)
        {
            garageShop.SaveLists();
        }
    }
}
