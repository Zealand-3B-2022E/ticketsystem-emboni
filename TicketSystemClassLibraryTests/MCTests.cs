using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Tests {
    [TestClass()]
    public class MCTests {
        [TestMethod()]
        public void PriceTest() {
            //Arrange
            double expectedValue = 125;
            //Act
            MC mc1 = new MC("ABCDEFGH", DateTime.Now);
            double actualValue = mc1.Price();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void VehicleTypeTest() {
            //Arrange
            string expectedValue = "MC";
            //Act
            MC mc2 = new MC("A1B2C3D4E5", DateTime.Now);
            string actualValue = mc2.VehicleType();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}