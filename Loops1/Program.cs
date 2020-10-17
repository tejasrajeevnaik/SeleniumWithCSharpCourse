using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display Fibonacci series: 0, 1, 1, 2, 3, 5, 8, 13 ...

            int a = 0;
            int b = 1;
            int total;
            string series = String.Empty;

            Console.Write("Enter the total numbers to be displayed in Fibonacci series: ");
            int.TryParse(Console.ReadLine(), out total);

            for (int i = 1; i <= total; i++)
            {
                if(1 == i)
                {
                    series = a.ToString();
                }
                else
                {
                    series = series + ", " + b;
                    int temp = b;
                    b = b + a;
                    a = temp;
                }
            }

            Console.WriteLine(series);
            Console.Read();
        }
    }
}
