using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageShopBooking
{
    class Trailers : Vehicle
    {
        private LiftType liftType;

        public Trailers(string regNumber, string brand, string modelYear, Owner owner, LiftType liftType) : base(regNumber, brand, modelYear, owner)
        {
            this.LiftType = liftType;
        }

        public LiftType LiftType { get => liftType; set => liftType = value; }
    }
}
