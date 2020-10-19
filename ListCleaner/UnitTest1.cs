using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListCleaner
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArrayList dataList = new ArrayList();
            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add("13.5");
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball soup");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");

            Assert.AreEqual(147, ListCleanerInt(dataList));
        }

        // Helper Methods
        public decimal ListCleanerDecimal(ArrayList dataList)
        {
            decimal sum = 0M;

            for (int counter = 0; counter < dataList.Count; counter++)
            {
                if (TypeCode.String == Type.GetTypeCode(dataList[counter].GetType()))
                {
                    dataList.RemoveAt(counter);
                    counter--;
                }
                else
                {
                    sum = sum + Convert.ToDecimal(dataList[counter]);
                }
            }
            return sum;
        }

        public int ListCleanerInt(ArrayList dataList)
        {
            int sum = 0;
            int number;

            foreach (object obj in dataList)
            {
                if (int.TryParse(obj.ToString(), out number))
                {
                    sum = sum + number;
                }
            }
            return sum;
        }
    }
}
