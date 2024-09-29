using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public interface ICustomer
    {
        string GetName();

        /// <summary>
        /// Processes the rental of a vehicle for a given number of days.
        /// </summary>
        /// <param name="vehicle">The vehicle to be rented.</param>
        /// <param name="days">The number of days the vehicle is rented for.</param>
        void RentVehicle(Vehicle vehicle, int days);

        /// <summary>
        /// Retrieves a list of vehicles that the customer has rented.
        /// </summary>
        /// <returns>A list of rented vehicles.</returns>
        List<Vehicle> GetRentedVehicles();



    }
}
