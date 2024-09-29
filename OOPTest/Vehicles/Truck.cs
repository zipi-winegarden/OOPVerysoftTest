using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public class Truck:Vehicle
    {
        //There is a possibility to change the capacity of a truck and
        //therefore the variable was not defined as constant
        private int capacity;

        public Truck(string licensePlate, string make, string model, double rentalPrice, int capacity)
               : base(licensePlate, make, model, rentalPrice)
        {
            this.capacity = capacity;
        }

        public int GetCapacity()
        {
            return capacity;
        }

        /// <summary>
        /// Calculates the rental cost for a truck based on a fixed daily rental price and additional cost based on its capacity.
        /// </summary>
        /// <param name="days">The number of days the truck is rented.</param>
        /// <returns>The total rental cost as a double, calculated by multiplying the rental price by the number of days and adding an additional cost based on the truck's capacity.</returns>
        public override double calculateRentalCost(int days)
        {
            
            return rentalPrice * days + (capacity * 10);
        }




        public override bool Equals(object obj)
        {
            return obj is Truck truck &&
                   base.Equals(obj) &&
                   rentalPrice == truck.rentalPrice &&
                   capacity == truck.capacity;
        }

        public override int GetHashCode()
        {
            int hashCode = -731789041;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + rentalPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + capacity.GetHashCode();
            return hashCode;
        }


        public override string ToString()
        {
            return $"Truck: {{ {base.ToString()}, Capacity: {capacity} }}";
        }
    }
}

