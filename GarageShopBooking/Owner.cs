using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageShopBooking
{
    class Owner
    {
        private string firstName, lastName;

        public Owner(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string FullName { get => firstName + lastName; }
    }
}
