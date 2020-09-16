using System;

namespace Learn2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");

            int a;

            int b = 0;

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("even");
            }

            else
            {
                Console.WriteLine("not even");
            }



        }
    }
}
