using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;

namespace ClassLibaryTest
{
    [TestClass]
    public class UnitTest1
    {
        Car car;
        MC mc;
        [TestMethod]
        public void CarPriceTest()
        {
            //Arrange
            car = new Car();
            decimal price;

            //Act
            price = car.Price();

            //Assert
            Assert.AreEqual(240, price);
        }

        [TestMethod]
        public void CarTypeTest()
        {
            //Arrange
            car = new Car();
            string type;

            //Act
            type = car.VechicleType();

            //Assert
            Assert.AreEqual("Car", type);

        }

        [TestMethod]
        public void MCTypeTest()
        {
            //Arrange
            mc = new MC();
            string type;

            //Act
            type = mc.VechicleType();

            //Assert
            Assert.AreEqual("MC", type);
        }

        [TestMethod]
        public void MCPriceTest()
        {
            //Arrange
            mc = new MC();
            decimal price;

            //Act
            price = mc.Price();

            //Assert
            Assert.AreEqual(125, price);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Too many chars.")]
        public void VehicleLicensePlate()
        {
            //Arrange
            Vehicle vehicle = new MC();

            //Act
            vehicle.LicensePlate = "12345678";
        }
    }
}
