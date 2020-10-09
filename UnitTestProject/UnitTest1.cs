using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Quiz")]
    public class UnitTest1
    {
        private int a;
        private int b;

        [ClassInitialize]
        public static void ClassStartUp(TestContext testContext)
        {
            Trace.WriteLine("This is Class initialize");
        }

        [ClassCleanup]
        public static void ClassCleanUp()
        {
            Trace.WriteLine("This is Class clean up");
        }

        [TestInitialize]
        public void MethodStartUp()
        {
            Trace.WriteLine("This is Method initialize");
            a = 10;
            b = 20;
        }

        [TestCleanup]
        public void MethodCleanUp()
        {
            Trace.WriteLine("This is Method clean up");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(30, a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail("This test will always fail.");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            Assert.AreEqual(2000, a * b);
        }
    }
}
