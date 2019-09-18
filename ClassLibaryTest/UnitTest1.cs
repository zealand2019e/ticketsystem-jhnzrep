using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibaryTest
{
    [TestClass]
    public class UnitTest1
    {
        Car car;
        [TestMethod]
        public void  CarPriceTest()
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
    }
}
