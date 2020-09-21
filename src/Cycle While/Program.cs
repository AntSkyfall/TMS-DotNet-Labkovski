using System;
using System.Threading;

namespace Cycle_While
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumberCount = 0;
            uint evenNumberCount = 0;
                Console.WriteLine("imput value");
            int firstValue = int.Parse(Console.ReadLine());
            while (Count < firstValue)
            {
                Count++;
                if (Count % 2 == 0)
                    Console.WriteLine(Count + " even");
                else
                    Console.WriteLine(Count + " not even");
            }
        }
    }
}
