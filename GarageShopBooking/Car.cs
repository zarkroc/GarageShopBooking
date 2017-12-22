using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageShopBooking
{
    class Car : Vehicle
    {
        private int doors, tires;
        private string liftType;
        private double height;

        public Car(int doors, int tires, string liftType, double height)
        {
            this.Doors = doors;
            this.Tires = tires;
            this.LiftType = liftType;
            this.Height = height;
        }

        public int Doors { get => doors; set => doors = value; }
        public int Tires { get => tires; set => tires = value; }
        public string LiftType { get => liftType; set => liftType = value; }
        public double Height { get => height; set => height = value; }
    }
}
