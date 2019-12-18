using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfacesTest;
namespace BreadTests
{
    [TestClass]
    public class BuyTests
    {
        [TestMethod]
        public void ShouldCountCorrectBill()
        {
            //Arrange
            Roll roll = new Roll();

            //Act
            double bill = roll.Buy(1, 3);
            double predictedBill = 7.5;

            //Assert
            Assert.AreEqual(bill, predictedBill);
        } 
    }
}