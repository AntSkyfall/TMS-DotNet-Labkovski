using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class ZooManager : IZooManager
    {
        List<AnimalBase<string>> Animals = new List<AnimalBase<string>>();

        public void Show()
        {
            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.Age);
            }
        }
    }
}
