using System;

namespace Calculator_switc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                try
                {
                    Console.WriteLine("imput first value ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("imput second value ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("incorrect input");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("select operation '+' '-' '/' '*' ");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;

                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;

                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;

                    case "/":

                        if (firstValue == 0)
                            Console.WriteLine(0);
                        else
                            Console.WriteLine(firstValue / secondValue);

                        Console.WriteLine(firstValue / secondValue);
                        break;

                    default:
                        Console.WriteLine("incorrect input");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
