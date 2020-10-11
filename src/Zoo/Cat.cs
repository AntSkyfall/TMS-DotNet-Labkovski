using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Cat : AnimalBase<int>
    {
        public void say()
        {
            Console.WriteLine("Meow - Meow");
        }
    }
}
