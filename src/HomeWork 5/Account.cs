using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_5
{
    class Account
    {
        public delegate void AccountStateHandler(string message);

        AccountStateHandler _del;

        public void RegisterHandler(AccountStateHandler del)
        {
            _del = del;
        }

        public Account(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;

            if (_del != null)
                _del($"It came to the account {sum}");
        }

        public void Witchdraw (int sum)
        {
            if (sum <= Sum)
            {
                Sum -= sum;

                if (_del != null)
                    _del($"Sum {sum} Withdrawn from the account");
            }
            else
            {
                if (_del != null)
                    _del($"Not enough money in the account");
            }
        }
    }
}
