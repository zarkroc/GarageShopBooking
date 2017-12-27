using System;

namespace GarageShopBooking
{
    class Vehicle
    {
        private string regNumber, brand, modelYear, formattedDate;
        private ServiceLevel serviceLevel;
        private int milage, repairTime;
        private Owner owner;
        private int extraWork;

        public Vehicle()
        {
            this.extraWork = 0;
            formattedDate = DateTime.Today.ToString("YYMMDD");
        }

        public Vehicle(string regNumber, string brand, string modelYear,  Owner owner)
        {
            this.regNumber = regNumber;
            this.brand = brand;
            this.modelYear = modelYear;
            this.owner = owner;
            this.extraWork = 0;
            formattedDate = DateTime.Today.ToString("YYMMDD");
        }

        public int Milage { get => milage; set
            {
                milage = value;
            }
        }
        public int RepairTime { get => repairTime; set => repairTime = value; }
        public string RegNumber { get => regNumber; set => regNumber = value; }
        public string Brand { get => brand; set => brand = value; }
        public string ModelYear { get => modelYear; set => modelYear = value; }
        public string FormattedDate { get => formattedDate; set => formattedDate = value; }
        public ServiceLevel ServiceLevel {
            get
            {
                return serviceLevel;
            }

            set
            {
                serviceLevel = value;
                if (value == ServiceLevel.Large)
                {
                    SetRepairTime(3);
                }
                if (value == ServiceLevel.Premium)
                {
                    SetRepairTime(4);
                }
                if (value == ServiceLevel.Medium)
                {
                    SetRepairTime(2);
                }
                if (value == ServiceLevel.Small)
                {
                    SetRepairTime(1);
                }
            }
        }
        public Owner Owner { get => owner; set => owner = value; }
        public int Price
        {
            get
            {
                return (int)serviceLevel + extraWork;
            }
        }

        /// <summary>
        /// Add extra cost and increase the numbers of days to work on the vehicle
        /// </summary>
        /// <param name="price"></param>
        public void AddWork(int price)
        {
            extraWork += price;
            repairTime++;
        }
        public override string ToString()
        {
            return String.Format("{0,7}, {1,-10} {2,-5}, {3},", regNumber, brand, modelYear, owner.FullName);
        }

        private void SetRepairTime(int time)
        {
            repairTime = time;
        }

        public string DetailedInfo()
        {
            string output = "RegNumber: " + regNumber + "\nbrand: " + brand + "\nModel Year: " + modelYear + "\nOwner: " + owner.FullName
                + "\nServiceLevel: " + serviceLevel.ToString() + "\nDays to repair: " + repairTime + "\nPrice: " + Price + "\nRegister date: " + formattedDate;
            return output;
        }
    }
}
