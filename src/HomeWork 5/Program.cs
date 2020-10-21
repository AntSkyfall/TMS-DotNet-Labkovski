using System;
using System.Runtime.CompilerServices;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(0);
            account.Added += AddedMessage;
            account.Witchdrawn += WitchdrawMessage;

            Console.WriteLine("Deposit amount: ");
            int Deposit = int.Parse(Console.ReadLine());
            account.Put(Deposit);
            Console.WriteLine($"On account sum: { account.Sum}");

            Console.WriteLine("Witchdraw: ");
            int Witchdraw = int.Parse(Console.ReadLine());
            account.Witchdraw(Witchdraw);
            Console.WriteLine($"On account sum: { account.Sum}");
            Console.ReadLine();
        }
        private static void AddedMessage(String message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static void WitchdrawMessage(String message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
