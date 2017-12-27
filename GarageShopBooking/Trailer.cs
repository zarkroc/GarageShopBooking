using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageShopBooking
{
    class Trailer : Trailers
    {
        private int tires;

        public Trailer(string regNumber, string brand, string modelYear, Owner owner, int tires, LiftType liftType) : base(regNumber, brand, modelYear, owner, liftType)
        {
            this.Tires = tires;
        }

        public int Tires { get => tires; set => tires = value; }
    }
}
