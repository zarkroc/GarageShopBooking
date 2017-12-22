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

        public GarageShop()
        {
            repairObjects = new List<Vehicle>();
        }

        internal List<Vehicle> RepairObjects { get => repairObjects; set => repairObjects = value; }

        public void AddVehicle(Vehicle vehicle)
        {
            RepairObjects.Add(vehicle);
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
            return null;
        }
    }
}
