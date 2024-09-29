using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public class RegularCustomer : ICustomer
    {
        private readonly string name;
        private List<Vehicle> rentedVehicles;

        public RegularCustomer(string name)
        {
            this.name = name;
            rentedVehicles = new List<Vehicle>();
        }


        public string GetName()
        {
            return name;
        }

        public List<Vehicle> GetRentedVehicles()
        {
            return new List<Vehicle>(rentedVehicles);
        }

        /// <summary>
        /// Rents a vehicle for a specified number of days.
        /// </summary>
        /// <param name="vehicle">The vehicle to be rented (must not be null).</param>
        /// <param name="days">Number of days for rental (must be greater than zero).</param>
        /// <exception cref="ArgumentNullException">Thrown if vehicle is null.</exception>
        /// <exception cref="ArgumentException">Thrown if days is less than or equal to zero.</exception>
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
            rentedVehicles.Add(vehicle);
            double cost = vehicle.calculateRentalCost(days);
            Console.WriteLine($"{name} rented {vehicle.GetMake()} {vehicle.GetModel()} for {days} days at {cost}$");
        }


        public override bool Equals(object obj)
        {
            return obj is RegularCustomer customer &&
                   name == customer.name &&
                   EqualityComparer<List<Vehicle>>.Default.Equals(rentedVehicles, customer.rentedVehicles);
        }

        public override int GetHashCode()
        {
            int hashCode = -2086003676;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Vehicle>>.Default.GetHashCode(rentedVehicles);
            return hashCode;
        }

        public override string ToString()
        {
            string rentedVehiclesInfo = string.Join(", ", rentedVehicles.Select(v => v.ToString()));
            return $"Regular Customer: {name}, Rented Vehicles: {rentedVehiclesInfo}";
        }
    }
}
