using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class ZooManager : IZooManager
    {
        public List<AnimalBase<string>> animals = new List<AnimalBase<string>>();

        public void Show()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.name);
                Console.WriteLine(animal.age);
            }
        }
    }
}
