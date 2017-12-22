﻿using System;
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

        public Vehicle(string regNumber, string brand, string modelYear,  Owner owner)
        {
            this.regNumber = regNumber;
            this.brand = brand;
            this.modelYear = modelYear;
            this.owner = owner;
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
