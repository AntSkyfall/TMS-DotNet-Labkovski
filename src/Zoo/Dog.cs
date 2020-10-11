using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Dog : AnimalBase<int>
    {
        public void say()
        {
            Console.WriteLine("Gav - Gav");
        }
    }
}
