using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageShopBooking
{
    class Vehicle
    {
        private string regNumber, brand, modelYear, formattedDate, serviceLevel;
        private int milage, repairTime;
        private Owner owner;

        public Vehicle()
        {
            this.RegNumber = String.Empty;
            this.Brand = String.Empty;
            this.ModelYear = String.Empty;
            this.FormattedDate = String.Empty;
            this.ServiceLevel = String.Empty;
            this.owner = new Owner(String.Empty, String.Empty);
            this.Milage = 0;
            this.RepairTime = 0;
        }

        public Vehicle(string regNumber, string brand, string modelYear, string formattedDate, string serviceLevel, Owner owner, int milage, int repairTime)
        {
            this.RegNumber = regNumber;
            this.Brand = brand;
            this.ModelYear = modelYear;
            this.FormattedDate = formattedDate;
            this.ServiceLevel = serviceLevel;
            this.owner = owner;
            this.Milage = milage;
            this.RepairTime = repairTime;
        }

        public int Milage { get => milage; set => milage = value; }
        public int RepairTime { get => repairTime; set => repairTime = value; }
        public string RegNumber { get => regNumber; set => regNumber = value; }
        public string Brand { get => brand; set => brand = value; }
        public string ModelYear { get => modelYear; set => modelYear = value; }
        public string FormattedDate { get => formattedDate; set => formattedDate = value; }
        public string ServiceLevel { get => serviceLevel; set => serviceLevel = value; }
        public Owner Owner { get => owner; set => owner = value; }
    }
}
