using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPractice;

namespace ClassLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyAddition()
        {
            int result = BasicMath.Addition(10, 15);
            Assert.AreEqual(25, result);
        }
    }
}
