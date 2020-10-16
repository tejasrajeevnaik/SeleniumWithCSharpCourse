using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TripUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_MilesPerGallonMethod()
        {
            Trip trip1 = new Trip("Leavonworth, Washington", 300, 200, 20);
            Console.WriteLine(trip1);

            Assert.AreEqual(15, trip1.GetMilesPerGallon());
        }

        [TestMethod]
        public void Test_CostPerMileMethod()
        {
            Trip trip1 = new Trip("Leavonworth, Washington", 300, 200, 20);
            Console.WriteLine(trip1);

            Assert.AreEqual((float)0.666666686534882, trip1.GetCostPerMile());
        }
    }
}
