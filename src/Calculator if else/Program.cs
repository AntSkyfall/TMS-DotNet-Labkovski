using System;

namespace Calculator_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("imput first value ");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("imput second value ");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("select operation '+' '-' '/' '*' ");
            action = Console.ReadLine();

            if (action == "+")
                    Console.WriteLine(firstValue + secondValue);
                else if (action == "-")
                    Console.WriteLine(firstValue - secondValue);
                else if (action == "/" & firstValue == 0)
                    Console.WriteLine(0);
                else if (action == "/")
                    Console.WriteLine(firstValue / secondValue);
                else if (action == "*")
                    Console.WriteLine(firstValue * secondValue);
                else
                    Console.WriteLine("incorrect input");
        }
                    }
        }
