using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Tests {
    [TestClass()]
    public class CarTests {
        [TestMethod()]
        public void CarTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest() {
            //Arrange
            double expectedValue = 240;
            //Act
            Car car1 = new Car("1233456",DateTime.Now);
            double actualValue = car1.Price();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void VehicleTypeTest() {
            //Arrange
            string expectedValue = "Car";
            //Act
            Car car2 = new Car("987654321", DateTime.Now);
            string actualValue = car2.VehicleType();
            //Assert
            Assert.AreEqual(expectedValue,actualValue);
            
            //Assert.Fail(); - Her begik jeg en fejl - hvis jeg fortsætter med at skrive yderligere kommandoer opfatter Visual Studio 'den' seneste kode som den, der skal køre.
        }
    }
}