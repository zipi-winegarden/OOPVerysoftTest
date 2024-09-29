using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public class Car : Vehicle
    {
        //Since vehicle type is not a variable that can be changed,
        //it was defined as fixed
        private readonly string type;

        public Car(string licensePlate, string make, string model, double rentalPrice, string type)
      : base(licensePlate, make, model, rentalPrice)
        {

            this.type = type;
        }


        public string GetCarType()
        {
            return type;
        }

        /// <summary>
        /// Calculates the rental cost for a vehicle based on a fixed daily rental rate.
        /// </summary>
        /// <param name="days">The number of days the vehicle is rented.</param>
        /// <returns>The total rental cost as a double, calculated by multiplying the fixed daily rate by the number of days.</returns>
        public override double calculateRentalCost(int days)
        {
            return rentalPrice * days;
        }


        public override bool Equals(object obj)
        {
            return obj is Car car &&
                   base.Equals(obj) &&
                   rentalPrice == car.rentalPrice &&
                   type == car.type;
        }

        public override int GetHashCode()
        {
            int hashCode = -1150227757;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + rentalPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(type);
            return hashCode;
        }
        public override string ToString()
        {
            return $"Car: {{{base.ToString()}, Type: {type}}}";
        }
    }
}
