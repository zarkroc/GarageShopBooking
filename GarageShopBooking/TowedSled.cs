namespace GarageShopBooking
{
    class TowedSled : Trailers
    {
        private int numOfSkids;

        public TowedSled() : base()
        {

        }

        public TowedSled(string regNumber, string brand, string modelYear, Owner owner, int numOfSkids, LiftType liftType) : base(regNumber, brand, modelYear, owner, liftType)
        {
            this.NumOfSkids = numOfSkids;
        }

        public int NumOfSkids { get => numOfSkids; set => numOfSkids = value; }
    }
}
