using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PropertyTaxCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_NewAssessedValue()
        {
            Property property1 = new Property("Bellevue, 98007", 125000);
            Console.WriteLine(property1);

            Assert.AreEqual(128375M, property1.GetNewAssessedValue());
        }

        [TestMethod]
        public void Test_ProposedPropertyTax()
        {
            Property property1 = new Property("Bellevue, 98007", 125000);
            Console.WriteLine(property1);

            Assert.AreEqual(1064.7625M, property1.GetProposedPropertyTax());
        }
    }
}
