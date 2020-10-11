using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class ZooManager : IManager
    {
        public List<AnimalBase<string>> animals = new List<AnimalBase<string>>();

        public void show()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.name);
                Console.WriteLine(animal.age);
            }
        }
    }
}
