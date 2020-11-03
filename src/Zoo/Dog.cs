using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Dog : AnimalBase<string>
    {
        public void Say()
        {
            Console.WriteLine("Gav - Gav");
        }
    }
}
