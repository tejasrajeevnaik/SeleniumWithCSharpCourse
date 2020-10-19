using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_SquareRootMethod()
        {
            Assert.AreEqual(7.0, MathHelper.SquareRoot(49));
        }

        [TestMethod]
        public void Test_SumMethod_Int()
        {
            Assert.AreEqual(35, MathHelper.Sum(10, 25));
        }

        [TestMethod]
        public void Test_SumMethod_Double()
        {
            Assert.AreEqual(35.0, MathHelper.Sum(10.0, 25.0));
        }

        [TestMethod]
        public void Test_SumMethod_Decimal()
        {
            Assert.AreEqual(35.5M, MathHelper.Sum(10.2M, 25.3M));
        }

        [TestMethod]
        public void Test_MethodRef()
        {
            int number1 = 25;
            MathHelper.MethodRef(ref number1);
            Console.WriteLine(number1);
        }

        [TestMethod]
        public void Test_MethodOut()
        {
            int number1;
            MathHelper.MethodOut(out number1);
            Console.WriteLine(number1);
        }

        [TestMethod]
        public void Test_ArrayPassing()
        {
            int[] scores = { 0, 1, 2, 3 };
            MathHelper.ArrayTest(scores);

            Console.WriteLine(scores);
        }
    }
}
