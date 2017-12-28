/// <summary>
/// Author: Tomas Perers
/// Data: 2017-12-27
/// </summary>
namespace GarageShopBooking
{
    /// <summary>
    /// Representation of a TowedSled Trailer vehicle.
    /// </summary>
    class TowedSled : Trailers
    {
        private int numOfSkids;

        /// <summary>
        /// Sets numOfSkids to 0.
        /// </summary>
        public TowedSled() : base()
        {
            this.numOfSkids = 0;
        }

        /// <summary>
        /// Creates an object with specefied values and calls the base class constructor.
        /// </summary>
        /// <param name="regNumber">String of regnumber of vehicle</param>
        /// <param name="brand">string brand name of vehicle</param>
        /// <param name="modelYear">string with model year of behicle</param>
        /// <param name="owner">Owner object of vehicle</param>
        /// <param name="numOfSkids">int number of skids on vehicle</param>
        /// <param name="liftType">LifType needed for vehicle</param>
        public TowedSled(string regNumber, string brand, string modelYear, Owner owner, int numOfSkids, LiftType liftType) : base(regNumber, brand, modelYear, owner, liftType)
        {
            this.NumOfSkids = numOfSkids;
        }

        /// <summary>
        /// Get and set the numOfSkids.
        /// </summary>
        public int NumOfSkids { get => numOfSkids; set => numOfSkids = value; }
    }
}
