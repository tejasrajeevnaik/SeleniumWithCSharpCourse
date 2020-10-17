using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    public class MathHelper
    {
        public static double SquareRoot(double value)
        {
            return Math.Sqrt(value);
        }
        
        public static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        public static double Sum(double value1, double value2)
        {
            return value1 + value2;
        }

        public static decimal Sum(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        public static void MethodRef(ref int number)
        {
            number = number * 2;
        }

        public static void MethodOut(out int number)
        {
            number = 10;
            number = number * 2;
        }
    }
}
