using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class AnimalBase<T> //Абстрактный класс тут
    {
        public T Name { get; set; }
        public T Age { get; set; }
        public T Weight { get; set; }
    }
}
