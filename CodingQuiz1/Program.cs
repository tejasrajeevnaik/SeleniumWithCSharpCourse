using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> validValues = new List<object>();
            List<object> invalidValues = new List<object>();
            List<int> distinctValueTracker = new List<int>(9) { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int numberOfValuesOutsideRange = 0;
            int numberOfNonNumericValues = 0;
            string userInputString = String.Empty;
            int userInputValue;

            while (true)
            {
                Console.WriteLine("Enter a value (type 'quit' to quit): ");
                userInputString = Console.ReadLine();

                if ("quit" == userInputString.ToLower())
                {
                    break;
                }

                if (int.TryParse(userInputString, out userInputValue))
                {
                    if (userInputValue >= 1 && userInputValue <= 9)
                    {
                        validValues.Add(userInputValue);
                        ++distinctValueTracker[userInputValue - 1];
                    }
                    else
                    {
                        invalidValues.Add(userInputValue);
                        ++numberOfValuesOutsideRange;
                    }
                }
                else
                {
                    invalidValues.Add(userInputString);
                    ++numberOfNonNumericValues;
                }
            }

            Console.Write("\n\nAll valid entries: ");
            foreach (object obj in validValues)
            {
                Console.Write(obj + ", ");
            }
            Console.WriteLine("\nTotal valid entries: {0}", validValues.Count);
            Console.WriteLine();
            Console.WriteLine("Value \t\t Number of times entered");
            for(int counter = 0; counter <= 8; counter++)
            {
                if(0!=distinctValueTracker[counter])
                {
                    Console.WriteLine($"{counter + 1} \t\t {distinctValueTracker[counter]}");
                }
            }

            Console.Write("\nAll invalid entries: ");
            foreach (object obj in invalidValues)
            {
                Console.Write(obj + ", ");
            }
            Console.WriteLine("\nTotal invalid entries: {0}", invalidValues.Count);
            Console.WriteLine("Total out of range entries: {0}", numberOfValuesOutsideRange);
            Console.WriteLine("Total non-numeric entries: {0}", numberOfNonNumericValues);

            Console.ReadKey();
        }
    }
}
