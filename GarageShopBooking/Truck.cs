using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageShopBooking
{
    class Truck : Vehicle
    {
        private int doors, tires;
        private string liftType;
        private double height;

        public Truck(string regNumber, string brand, string modelYear, Owner owner, int doors, int tires, string liftType, double height) : base(regNumber, brand, modelYear, owner)
        {
            this.doors = doors;
            this.tires = tires;
            this.liftType = liftType;
            this.height = height;
        }

        public int Doors { get => doors; set => doors = value; }
        public int Tires { get => tires; set => tires = value; }
        public string LiftType { get => liftType; set => liftType = value; }
        public double Height { get => height; set => height = value; }
    }
}
