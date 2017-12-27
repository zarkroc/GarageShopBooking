using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageShopBooking
{
    class Vehicle
    {
        private string regNumber, brand, modelYear, formattedDate;
        private ServiceLevel serviceLevel;
        private int milage, repairTime;
        private Owner owner;
        private int price;
        private int extraWork;

        public Vehicle(string regNumber, string brand, string modelYear,  Owner owner)
        {
            this.regNumber = regNumber;
            this.brand = brand;
            this.modelYear = modelYear;
            this.owner = owner;
            this.extraWork = 0;
        }

        public int Milage { get => milage; set => milage = value; }
        public int RepairTime { get => repairTime; set => repairTime = value; }
        public string RegNumber { get => regNumber; set => regNumber = value; }
        public string Brand { get => brand; set => brand = value; }
        public string ModelYear { get => modelYear; set => modelYear = value; }
        public string FormattedDate { get => formattedDate; set => formattedDate = value; }
        public ServiceLevel ServiceLevel { get => serviceLevel; set => serviceLevel = value; }
        public Owner Owner { get => owner; set => owner = value; }
        public int Price
        {
            get
            {
                return (int)serviceLevel + extraWork;
            }
        }


        public void AddWork(int price)
        {
            extraWork += price;    
        }
        public override string ToString()
        {
            return String.Format("{0,7}, {1,10} {1, 10}", regNumber, brand, owner.ToString());
        }

        public string DetailedInfo()
        {
            return regNumber + "\n" + brand + "\n" + modelYear + "\n" + owner.ToString() + "\n" + serviceLevel.ToString();
        }
    }
}
