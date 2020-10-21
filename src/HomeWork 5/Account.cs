using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_5
{
    class Account
    {
        public delegate void AccountStateHandler(string message);

        public event AccountStateHandler Added;
        public event AccountStateHandler Witchdrawn;

        //public void RegisterHandler(AccountStateHandler del)

        public Account(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;

            if (Added != null)
                Added($"It came to the account {sum}");
        }

        public void Witchdraw (int sum)
        {
            if (sum <= Sum)
            {
                Sum -= sum;

                if (Witchdrawn != null)
                    Witchdrawn($"Sum {sum} Withdrawn from the account");
            }
            else
            {
                if (Witchdrawn != null)
                    Witchdrawn($"Not enough money in the account");
            }
        }
    }
}
