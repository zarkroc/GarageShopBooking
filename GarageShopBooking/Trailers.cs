/// <summary>
/// Author: Tomas Perers
/// Data: 2017-12-27
/// </summary>
namespace GarageShopBooking
{
    /// <summary>
    /// Representation of a Trailers Vehicle.
    /// </summary>
    class Trailers : Vehicle
    {
        private LiftType liftType;

        /// <summary>
        /// Sets the lifttype to Light.
        /// </summary>
        public Trailers () : base ()
        {
            this.LiftType = LiftType.Light;
        }
        /// <summary>
        /// Creates and object with specefied values and calls the base class.
        /// </summary>
        /// <param name="regNumber">String of regnumber of vehicle</param>
        /// <param name="brand">string brand name of vehicle</param>
        /// <param name="modelYear">string with model year of behicle</param>
        /// <param name="owner">Owner object of vehicle</param>
        /// <param name="liftType">LifType needed for vehicle</param>
        public Trailers(string regNumber, string brand, string modelYear, Owner owner, LiftType liftType) : base(regNumber, brand, modelYear, owner)
        {
            this.LiftType = liftType;
        }

        /// <summary>
        /// Gets and sets the liftType
        /// </summary>
        public LiftType LiftType { get => liftType; set => liftType = value; }
    }
}
