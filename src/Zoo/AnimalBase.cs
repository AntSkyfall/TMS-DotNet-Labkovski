using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class AnimalBase<T> //Абстрактный класс тут
    {
        public string name { get; set; }
        public T age { get; set; }
    }
}
