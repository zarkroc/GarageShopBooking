using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageShopBooking
{
    class TowedSled : Trailers
    {
        private int numOfSkids;

        public TowedSled(string regNumber, string brand, string modelYear, Owner owner, int numOfSkids, string liftType) : base(regNumber, brand, modelYear, owner, liftType)
        {
            this.NumOfSkids = numOfSkids;
        }

        public int NumOfSkids { get => numOfSkids; set => numOfSkids = value; }
    }
}
