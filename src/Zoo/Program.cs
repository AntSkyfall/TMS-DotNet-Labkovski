using System;

namespace Zoo
{

    public class Program
    {
        static void Main(string[] args)
        {
            Cat CatVasya = new Cat();
            CatVasya.name = "Vasiliy";
            CatVasya.age = 1;

            Dog DogPetya = new Dog();
            DogPetya.name = "Peter";

            IZooManager zooManager= new ZooManager();
            zooManager.Animals.Add(CatVasya);
            zooManager.Animals.Add(DogPetya);

            CatVasya.say();
            DogPetya.say();

            zooManager.Show();

            Console.ReadLine();

        }
    }
}
