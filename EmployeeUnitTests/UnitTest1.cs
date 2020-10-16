using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeUnitTests
{
    [TestClass]
    public class EmployeeUnitTests
    {
        private static string nameInStandardFormat;
        private static string nameInSortableFormat;
        private static Employee employee;

        [ClassInitialize]
        public static void ClassStartUp(TestContext testContext)
        {
            nameInStandardFormat = "Tejas Naik";
            nameInSortableFormat = "Naik, Tejas";
            employee = new Employee("M1010016", "Tejas", "Naik");
        }

        [TestMethod]
        public void VerifyNameInStandardFormat()
        {
            Assert.AreEqual(nameInStandardFormat, employee.GetNameInStandardFormat());
        }

        [TestMethod]
        public void VerifyNameInSortableFormat()
        {
            Assert.AreEqual(nameInSortableFormat, employee.GetNameInSortableFormat());
        }
    }
}
