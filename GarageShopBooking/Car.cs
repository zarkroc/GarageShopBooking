/// <summary>
/// Author: Tomas Perers
/// Data: 2017-12-27
/// </summary>
namespace GarageShopBooking
{
    /// <summary>
    /// Representation of a Car Vehicle.
    /// </summary>
    class Car : Vehicle
    {
        private int doors, tires;
        private LiftType liftType;
        private double height;

        /// <summary>
        /// Emty constructor sets doors and height to 0 and liftype to Light.
        /// </summary>
        public Car() : base()
        {
            this.doors = 0;
            this.height = 0.0;
            liftType = LiftType.Light;
        }
        /// <summary>
        /// Creates and object with specefied values adn calls the base class.
        /// </summary>
        /// <param name="regNumber">String of regnumber of vehicle</param>
        /// <param name="brand">string brand name of vehicle</param>
        /// <param name="modelYear">string with model year of behicle</param>
        /// <param name="owner">Owner object of vehicle</param>
        /// <param name="doors">int numbers of doors on vehicle</param>
        /// <param name="tires">int number of tires on vehicle</param>
        /// <param name="liftType">LifType needed for vehicle</param>
        /// <param name="height">int height of vehicle</param>
        public Car(string regNumber, string brand, string modelYear, Owner owner, int doors, int tires, LiftType liftType, double height) : base (regNumber, brand, modelYear, owner)
        {
            this.doors = doors;
            this.tires = tires;
            this.liftType = liftType;
            this.height = height;
        }
        /// <summary>
        /// Gets and sets doors, tires, liftype and Height.
        /// </summary>
        public int Doors { get => doors; set => doors = value; }
        public int Tires { get => tires; set => tires = value; }
        public LiftType LiftType { get => liftType; set => liftType = value; }
        public double Height { get => height; set => height = value; }
    }
}
