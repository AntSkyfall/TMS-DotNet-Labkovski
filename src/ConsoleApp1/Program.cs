using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = int.Parse(Console.ReadLine());
            if (firstValue % 2 == 0)
                Console.WriteLine(firstValue + " even");
            else if (firstValue % 2 != 0)
                Console.WriteLine(firstValue + " not even");
        }
    }
}
