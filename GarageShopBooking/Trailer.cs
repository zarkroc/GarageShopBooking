/// <summary>
/// Author: Tomas Perers
/// Data: 2017-12-27
/// </summary>
namespace GarageShopBooking
{
    /// <summary>
    /// Represeantation of a Trailer Trailers vehicle object.
    /// </summary>
    class Trailer : Trailers
    {
        private int tires;

        /// <summary>
        /// Sets num of tires to 0 and calls the base class.
        /// </summary>
        public Trailer() : base()
        {
            this.tires = 0;
        }

        /// <summary>
        /// Creates and object with specefied values and calls the base class.
        /// </summary>
        /// <param name="regNumber">String of regnumber of vehicle</param>
        /// <param name="brand">string brand name of vehicle</param>
        /// <param name="modelYear">string with model year of behicle</param>
        /// <param name="owner">Owner object of vehicle</param>
        /// <param name="tires">int number of tires on vehicle</param>
        /// <param name="liftType">LifType needed for vehicle</param>
        public Trailer(string regNumber, string brand, string modelYear, Owner owner, int tires, LiftType liftType) : base(regNumber, brand, modelYear, owner, liftType)
        {
            this.Tires = tires;
        }
        /// <summary>
        /// Gets and sets the number of tires.
        /// </summary>
        public int Tires { get => tires; set => tires = value; }
    }
}
