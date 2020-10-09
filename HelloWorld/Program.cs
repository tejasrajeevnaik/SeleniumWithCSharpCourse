using System;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "Number a", "Number b", "Sum of a and b"));
            Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", a, b, a + b));
        }
    }
}
