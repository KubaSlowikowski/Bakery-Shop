using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //public void Buy(int id, int ammount = 3, double Price=2.5)
        //  {
        //        double bill = Price * ammount;
        //          Assert.AreEqual(3, bill);
        //        }
        public double Add(double num1, double num2)
        {
            return num1 + num2;

        }
    }

}
