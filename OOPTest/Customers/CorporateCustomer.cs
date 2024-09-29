using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPTest
{
    public class CorporateCustomer:ICustomer
    {

        private readonly string companyName;
        private List<Vehicle> rentedVehicles;

        public CorporateCustomer(string companyName)
        {
            this.companyName = companyName;
            rentedVehicles = new List<Vehicle>();
        }

 

        public string GetName()
        {
            return companyName;
        }



        public List<Vehicle> GetRentedVehicles()
        {
            return new List<Vehicle>(rentedVehicles);
        }

        /// <summary>
        /// Rents a vehicle for a specified number of days with a discount for corporate customers.
        /// </summary>
        /// <param name="vehicle">The vehicle to be rented.</param>
        /// <param name="days">Number of days for rental.</param>
        public void RentVehicle(Vehicle vehicle, int days)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException(nameof(vehicle), "Vehicle cannot be null.");
            }
            if (days <= 0)
            {
                throw new ArgumentException("Days must be greater than zero.", nameof(days));
            }
            rentedVehicles.Add(vehicle); // Add the rented vehicle to the list

            // Calculate rental cost with a discount of 10%
            double cost = vehicle.calculateRentalCost(days) * 0.9;
            Console.WriteLine($" Corporate: {companyName} rented {vehicle.GetMake()} {vehicle.GetModel()} for {days} days at {cost}$");
        }

        public override bool Equals(object obj)
        {
            return obj is CorporateCustomer customer &&
                   companyName == customer.companyName &&
                   EqualityComparer<List<Vehicle>>.Default.Equals(rentedVehicles, customer.rentedVehicles);
        }
        public override int GetHashCode()
        {
            int hashCode = 2013144957;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(companyName);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Vehicle>>.Default.GetHashCode(rentedVehicles);
            return hashCode;
        }
        public override string ToString()
        {
            string rentedVehiclesInfo = string.Join(", ", rentedVehicles.Select(v => v.ToString()));
            return $"Corporate Customer: {companyName}, Rented Vehicles: {rentedVehiclesInfo}";
        }
    }
}

