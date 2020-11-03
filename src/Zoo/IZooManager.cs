using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public interface IZooManager
    {
        List<AnimalBase<string>> Animals { get; set; }

        public void Show()
        {
            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.Age);
                Console.WriteLine(animal.Weight);
            }
        }
    }
}
