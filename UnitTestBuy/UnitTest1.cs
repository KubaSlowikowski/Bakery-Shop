using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTestBuy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBuy0()
        {
            int ammount = 3;
            double Price = 2.5;
            double bill = Price * ammount;
            Assert.AreEqual(bill, 7.5);
        }
        [TestMethod]
        public void TestBuy1()
        {
            int ammount = 0;
            double Price = 2.5;
            double bill = Price * ammount;
            Assert.AreEqual(bill, 0);
        }
        [TestMethod]
        public void TestBuy2()
        {
            int ammount = 3;
            double Price = 0;
            double bill = Price * ammount;
            Assert.AreEqual(bill, 0);
        }

        [TestMethod]
        public void TestBuy3()
        {
            int ammount = -3;
            double Price = 2;
            double bill = Price * ammount;
            Assert.AreEqual(bill, null);
        }

        [TestMethod]
        public void TestBuy4()
        {
            int ammount = 3;
            double Price = -2;
            double bill = Price * ammount;
            Assert.AreEqual(bill, null);
        }
    }
}