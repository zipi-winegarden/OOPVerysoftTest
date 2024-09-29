using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest

{

    /// <summary>
    /// Represents a vehicle in the rental system.
    /// </summary>
    public abstract class Vehicle
    {
        /*
        Since these variables are not supposed
       to be updated during the program at all,
       they are defined as constant*/
        private readonly string licensePlate;
        private readonly string make; //Manufacturer of the vehicle
        private readonly string model;


        protected double rentalPrice;


        public Vehicle(string licensePlate, string make, string model, double rentalPrice)
        {
            this.licensePlate = licensePlate;
            this.make = make;
            this.model = model;
            this.rentalPrice = rentalPrice;
        }
        public string GetLicensePlate()
        {
            return licensePlate;
        }
        public string GetMake()
        {
            return make;
        }
        public string GetModel()
        {
            return model;
        }
        public double GetRentalPrice()
        {
            return rentalPrice;
        }

        /// <summary>
        /// Calculates the rental cost of a vehicle.
        /// </summary>
        /// <param name="days">The number of days for which the vehicle is rented.</param>
        /// <returns>The total rental cost as a double.</returns>
        public abstract double calculateRentalCost(int days);



        public override bool Equals(object obj)
        {
            return obj is Vehicle vehicle &&
                   licensePlate == vehicle.licensePlate &&
                   make == vehicle.make &&
                   model == vehicle.model &&
                   rentalPrice == vehicle.rentalPrice;
        }

        public override int GetHashCode()
        {
            int hashCode = -1669999719;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(licensePlate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(make);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(model);
            hashCode = hashCode * -1521134295 + rentalPrice.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"LicensePlate: {licensePlate}, Make: {make}, Model: {model}, RentalPric: {rentalPrice}";
        }
    }
}
