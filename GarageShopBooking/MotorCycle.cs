/// <summary>
/// Author: Tomas Perers
/// Data: 2017-12-27
/// </summary>
namespace GarageShopBooking
{
    /// <summary>
    /// Representation of a MotorCycle vehicle.
    /// </summary>
    class MotorCycle : Vehicle
    {
        private int tires;
        
        /// <summary>
        /// Create an object with no properties set.
        /// </summary>
        public MotorCycle() : base()
        {
            this.tires = 0;
        }
        /// <summary>
        /// Creates an object with specefied values and calls the base class.
        /// </summary>
        /// <param name="regNumber">String of regnumber of vehicle</param>
        /// <param name="brand">string brand name of vehicle</param>
        /// <param name="modelYear">string with model year of behicle</param>
        /// <param name="owner">Owner object of vehicle</param>
        /// <param name="tires">int number of tires on vehicle</param>
        public MotorCycle(string regNumber, string brand, string modelYear, Owner owner, int tires) : base(regNumber, brand, modelYear, owner)
        {
            this.Tires = tires;
        }
        /// <summary>
        /// Sets and gets Tires.
        /// </summary>
        public int Tires { get => tires; set => tires = value; }
    }
}
