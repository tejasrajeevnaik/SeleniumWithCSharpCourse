using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoanProgram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AutoLoanClasss()
        {
            AutoLoan autoLoan = new AutoLoan(2018, "Premium", "VW", "Metallic Grey", 123, "Tejas", "Naik", 7.5M, 12000M, 4M);
            Console.WriteLine(autoLoan);

            Assert.AreEqual(2925M, autoLoan.CalculateInterest());
        }

        [TestMethod]
        public void Test_HomeLoanClasss()
        {
            HomeLoan homeLoan = new HomeLoan("Bellevue, Washington", 2010, 5000, 456, "Tejas", "Naik", 3.5M, 210000M, 30M);
            Console.WriteLine(homeLoan);

            Assert.AreEqual(3010M, homeLoan.CalculateInterest());
        }
    }
}
