using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    internal class VehicleRental
    {
        static void Main(string[] args) { 
            //Setting up an instance of vehicles
            Vehicle car1 = new Car("ABC123", "Toyota", "Camry", 50.0, "Sedan");
            Vehicle truck1 = new Truck("XYZ789", "Ford", "F-150", 80.0, 1000);

            // Setting up an instance of customers
            ICustomer regularCustomer = new RegularCustomer("David Cohen");
            ICustomer corporateCustomer = new CorporateCustomer("Tech Innovations");

            // Car rental process
            try
            {
                regularCustomer.RentVehicle(car1, 3);
                regularCustomer.RentVehicle(truck1, 5);
                corporateCustomer.RentVehicle(car1, 3);
                corporateCustomer.RentVehicle(truck1, 5);

                Console.WriteLine(regularCustomer);
                Console.WriteLine(corporateCustomer);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        
      
        
           
        }
    }
}