using System;
using System.Runtime.CompilerServices;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(0);
            account.RegisterHandler(new Account.AccountStateHandler(Show_message));

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
        private static void Show_message(String message)
        {
            Console.WriteLine(message);
        }
    }
}
