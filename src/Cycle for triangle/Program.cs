using System;

namespace Cycle_for_triangle
{
    class Program // Выводит в консоль рисунок треугольника
    {
        static void Main(string[] args)
        {
            Console.WriteLine("imput vertical triangle ");
            int vertical = int.Parse(Console.ReadLine());

            for (int i = 0; i <= vertical; i++) //Vertical
            {
                Console.WriteLine("#");

                for (int a = 0; a <= i; a++)//Horizontal
                {
                    Console.Write("#");
                    continue;
                }
            }
            for (int i = vertical; i >= 0; i--)
            {
                Console.WriteLine("#");

                for (int a = i; a >= 0; a--)
                {
                    Console.Write("#");
                    continue;
                }
            }
        }
    }
}
