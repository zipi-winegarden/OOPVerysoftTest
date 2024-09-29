using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace OOPTest.Tests
{
    [TestClass]
    public class VehicleRentalTests
    {
        [TestMethod]
        public void TestRegularCustomerRental()
        {
            Vehicle car = new Car("ABC123", "Toyota", "Camry", 50.0, "Sedan");
            ICustomer regularCustomer = new RegularCustomer("David Cohen");

          
            regularCustomer.RentVehicle(car, 3);
            List<Vehicle> rentedVehicles = regularCustomer.GetRentedVehicles();

      
            Assert.AreEqual(1, rentedVehicles.Count);
            Assert.AreEqual("Toyota", rentedVehicles[0].GetMake());
            Assert.AreEqual("Camry", rentedVehicles[0].GetModel());
        }
        [TestMethod]
        public void TestCorporateCustomerRentalWithDiscount()
        {
            Vehicle truck = new Truck("XYZ789", "Ford", "F-150", 80.0, 1000);
            ICustomer corporateCustomer = new CorporateCustomer("Tech Innovations");


            corporateCustomer.RentVehicle(truck, 5);
            var rentedVehicles = corporateCustomer.GetRentedVehicles();

      
            Assert.AreEqual(1, rentedVehicles.Count);
            Assert.AreEqual("Ford", rentedVehicles[0].GetMake());
            Assert.AreEqual("F-150", rentedVehicles[0].GetModel());
        }
    }
}
