using System;
using System.Threading;

namespace Cycle_While
{
    class Program
    {
        static void Main(string[] args) // Считает количество четных и нечетных чисел в определенном диапазоне
        {
            int oddNumberCount = 0;
            int evenNumberCount = 0;
                Console.WriteLine("imput the lower range");
            int firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("imput the limit range");
            int secondValue = int.Parse(Console.ReadLine());

            while (firstValue <= secondValue)
            {
                if (firstValue % 2 == 0)
                {
                    evenNumberCount++;
                }

                else
                {
                    oddNumberCount++;
                }

                firstValue++;
            }
            Console.WriteLine(evenNumberCount + " Even");
            Console.WriteLine(oddNumberCount + "Odd");
        }
    }
}
