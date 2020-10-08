using System;

namespace Zoo
{
    abstract class AnimalBase //Абстрактный класс тут
    {
        public string name;
        public int age = 1;
    }
    class Cat : AnimalBase
    {
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class british : Cat // Наследование
    {
        public void PublicProperties()
        {
            Console.WriteLine("PublicProperties");
        }
        private void PrivateProperties()// Была использована инкапсуляция
        {
            Console.WriteLine("not for the eyes");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            british Vasya = new british();
            Vasya.age = 5;
            Vasya.name = "Vasiliy";
            Vasya.GetInfo();
            Vasya.PublicProperties();




        }
    }
}
