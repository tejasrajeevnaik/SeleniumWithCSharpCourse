using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RetailStore;

namespace RetailStoreUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private static Receipt validReceipt;
        private static Receipt invalidReceipt;

        [ClassInitialize]
        public static void ClassStartUp(TestContext testContext)
        {
            validReceipt = new Receipt(123, DateTime.Today, 234, "Tejas Naik", "Magnolia Society", 9359320064, 333, "Cool product", 200, 25);
            invalidReceipt = new Receipt(-1, DateTime.Today, -2, "Tejas Naik", "Magnolia Society", 9359320064, 9999, "Cool product", 15000, -25);
        }

        #region Positive tests
        [TestMethod]
        [TestCategory("Positive tests")]
        public void Test_ValidReceiptNumber()
        {
            Console.WriteLine(validReceipt);
            Assert.AreEqual(123, validReceipt.ReceiptNumber);
        }

        [TestMethod]
        [TestCategory("Positive tests")]
        public void Test_ValidCustomerNumber()
        {
            Console.WriteLine(validReceipt);
            Assert.AreEqual(234, validReceipt.CustomerNumber);
        }

        [TestMethod]
        [TestCategory("Positive tests")]
        public void Test_ValidItemNumber()
        {
            Console.WriteLine(validReceipt);
            Assert.AreEqual(333, validReceipt.ItemNumber);
        }

        [TestMethod]
        [TestCategory("Positive tests")]
        public void Test_ValidItemUnitPrice()
        {
            Console.WriteLine(validReceipt);
            Assert.AreEqual(200, validReceipt.ItemUnitPrice);
        }

        [TestMethod]
        [TestCategory("Positive tests")]
        public void Test_ValidItemQuantityPurchased()
        {
            Console.WriteLine(validReceipt);
            Assert.AreEqual(25, validReceipt.ItemQuantityPurchased);
        }
        #endregion

        #region Negative tests
        [TestMethod]
        [TestCategory("Negative tests")]
        public void Test_InvalidReceiptNumber()
        {
            Console.WriteLine(invalidReceipt);
            Assert.AreEqual(1, invalidReceipt.ReceiptNumber);
        }

        [TestMethod]
        [TestCategory("Negative tests")]
        public void Test_InvalidCustomerNumber()
        {
            Console.WriteLine(invalidReceipt);
            Assert.AreEqual(1, invalidReceipt.CustomerNumber);
        }

        [TestMethod]
        [TestCategory("Negative tests")]
        public void Test_InvalidItemNumber()
        {
            Console.WriteLine(invalidReceipt);
            Assert.AreEqual(1, invalidReceipt.ItemNumber);
        }

        [TestMethod]
        [TestCategory("Negative tests")]
        public void Test_InvalidItemUnitPrice()
        {
            Console.WriteLine(invalidReceipt);
            Assert.AreEqual(1, invalidReceipt.ItemUnitPrice);
        }

        [TestMethod]
        [TestCategory("Negative tests")]
        public void Test_InvalidItemQuantityPurchased()
        {
            Console.WriteLine(invalidReceipt);
            Assert.AreEqual(1, invalidReceipt.ItemQuantityPurchased);
        }
        #endregion
    }
}
