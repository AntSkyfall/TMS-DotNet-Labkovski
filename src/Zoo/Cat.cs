using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Cat : AnimalBase<string>
    {
        public void Say()
        {
            Console.WriteLine("Meow - Meow");
        }
    }
}
