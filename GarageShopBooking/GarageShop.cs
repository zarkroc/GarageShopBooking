using System;
using System.Collections.Generic;
using System.IO;
/// <summary>
/// Author: Tomas Perers
/// Date: 2017-12-28
/// </summary>
namespace GarageShopBooking
{
    /// <summary>
    /// A representation of a Garage shop
    /// </summary>
    class GarageShop
    {
        /// <summary>
        /// Lists of objects in the garage.
        /// </summary>
        private List<Vehicle> repairObjects;
        private List<Vehicle> readyObjects;
        private string saveDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +"\\";
        private const string readyObjectsFilleName = "readyObjects.json";
        private const string repairObjectsFileNAme = "repairObjects.json";

        /// <summary>
        /// Initiates two lists when called.
        /// </summary>
        public GarageShop()
        {
            repairObjects = new List<Vehicle>();
            readyObjects = new List<Vehicle>();
        }
        /// <summary>
        /// Get and set RepairObjects and ReadyObjects.
        /// </summary>
        internal List<Vehicle> RepairObjects { get => repairObjects; set => repairObjects = value; }
        internal List<Vehicle> ReadyObjects { get => readyObjects; set => readyObjects = value; }

        /// <summary>
        /// Add a vehicle to the repairobjects.
        /// </summary>
        /// <param name="vehicle"></param>
        public void AddVehicle(Vehicle vehicle)
        {
            RepairObjects.Add(vehicle);
        }

        /// <summary>
        /// Moves a vehicle from repairobjects to readyobjects.
        /// </summary>
        /// <param name="index"></param>
        public void VehicleReady(int index)
        {
            readyObjects.Add(repairObjects[index]);
            repairObjects.RemoveAt(index);
        }

        /// <summary>
        /// Search for a vehicle with the specefied reg number.
        /// </summary>
        /// <param name="regNumber"></param>
        /// <returns></returns>
        public Vehicle SearchVehicle(String regNumber)
        {
            // Converts the regnumber to lowecase.
            regNumber = regNumber.ToLower();
            foreach (Vehicle vehicle in RepairObjects)
            {
                if (vehicle.RegNumber.Equals(regNumber))
                {
                    return vehicle;
                }
            }
            foreach (Vehicle vehicle in ReadyObjects)
            {
                if (vehicle.RegNumber.Equals(regNumber))
                {
                    return vehicle;
                }
            }
            return null;
        }

        /// <summary>
        /// Checksout a vehicle by getting the price, displaying the price and removing from list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int CheckOutVehicle(int index)
        {
            int price = ReadyObjects[index].Price;
            ReadyObjects.RemoveAt(index);
            return price;
        }

        /// <summary>
        /// Write the lists to a Json file.
        /// </summary>
        public void SaveLists()
        {
            // Write the contents of the variable someClass to a file.
            FileHandler.WriteToFile<List<Vehicle>>(saveDirectory + repairObjectsFileNAme , repairObjects);
            FileHandler.WriteToFile<List<Vehicle>>(saveDirectory + readyObjectsFilleName , readyObjects);

            // Read the file contents back into a variable.
        }

        /// <summary>
        /// Restore the lists from a json file.
        /// </summary>
        public void RestoreLists()
        {
            if (File.Exists(saveDirectory + readyObjectsFilleName))
            {
                readyObjects = FileHandler.ReadFromFile<List<Vehicle>>(saveDirectory + readyObjectsFilleName);
            }
            if (File.Exists(saveDirectory + repairObjectsFileNAme))
            {
                repairObjects = FileHandler.ReadFromFile<List<Vehicle>>(saveDirectory + repairObjectsFileNAme);
            }
        }

    }
}
