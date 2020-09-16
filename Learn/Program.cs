using System;

namespace Learn
{
    class Program // СЧИТАЕТ СРЕДНЕЕ АРИФМЕТИЧЕСКОЕ 
    {        static void Main(string[] args)
        {
            string secondnumber, first;

            Console.WriteLine("input number one");
            
            first = Console.ReadLine();

            double one = Convert.ToDouble(first);

            Console.WriteLine("input number two");

            secondnumber = Console.ReadLine();

            double two = Convert.ToDouble(secondnumber);

            double result = (one + two) / 2;

            Console.WriteLine("The arithmetic mean is: " + result);

        }
    }
}
