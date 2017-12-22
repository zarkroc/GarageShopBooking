using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageShopBooking
{
    class MotorCycle : Vehicle
    {
        private int tires;
        private string liftType;

        public MotorCycle(string regNumber, string brand, string modelYear, Owner owner, int tires, string liftType, double height) : base(regNumber, brand, modelYear, owner)
        {
            this.Tires = tires;
            this.LiftType = liftType;
        }

        public int Tires { get => tires; set => tires = value; }
        public string LiftType { get => liftType; set => liftType = value; }
    }
}
