using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageShopBooking
{
    class GarageShop
    {
        private List<Vehicle> repairObjects;
        private List<Vehicle> readyObjects;

        public GarageShop()
        {
            repairObjects = new List<Vehicle>();
            readyObjects = new List<Vehicle>();
        }

        internal List<Vehicle> RepairObjects { get => repairObjects; set => repairObjects = value; }
        internal List<Vehicle> ReadyObjects { get => readyObjects; set => readyObjects = value; }

        public void AddVehicle(Vehicle vehicle)
        {
            RepairObjects.Add(vehicle);
        }

        public void VehicleReady(int index)
        {
            readyObjects.Add(repairObjects[index]);
            repairObjects.RemoveAt(index);
        }

        public Vehicle SearchVehicle(String regNumber)
        {
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

        public int CheckOutVehicle(int index)
        {
            int price = ReadyObjects[index].Price;
            ReadyObjects.RemoveAt(index);
            return price;
        }
    }
}
