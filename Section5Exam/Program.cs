using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearString;
            int yearInt;
            
            while (true)
            {
                Console.Write("Enter the year: ");
                yearString = Console.ReadLine();

                if(int.TryParse(yearString, out yearInt))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid year. Please try again.");
                }
            }

            DisplayLeapYearOrNot(yearInt);
        }

        private static void DisplayLeapYearOrNot(int year)
        {
            bool isLeapYear = false;
            bool divisibleBy4 = false;
            bool divisibleBy100 = false;
            bool divisibleBy400 = false;

            if (0 == year % 4)
            {
                divisibleBy4 = true;
                isLeapYear = true;

                if (0 == year % 100)
                {
                    divisibleBy100 = true;
                    isLeapYear = false;
                }
                if (0 == year % 400)
                {
                    divisibleBy400 = true;
                    isLeapYear = true;
                }
            }

            Console.WriteLine($"The entered year: {year}");
            Console.WriteLine($"Divisible by 4: {divisibleBy4}");
            Console.WriteLine($"Divisible by 100: {divisibleBy100}");
            Console.WriteLine($"Divisible by 400: {divisibleBy400}");
            Console.WriteLine($"Leap year: {isLeapYear}");
            Console.ReadLine();
        }
    }
}
