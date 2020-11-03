using System;

namespace Zoo
{

    public class Program
    {
        static void Main(string[] args)
        {
            Cat cats = new Cat();
            cats.Name = "Vasiliy";
            cats.Age = "1";
            cats.Weight = "10";

            Dog dogs = new Dog();
            dogs.Name = "Peter";
            dogs.Age = "2";
            dogs.Weight = "20";

            IZooManager zooManager= new ZooManager();
            zooManager.Animals.Add(cats);
            zooManager.Animals.Add(dogs);

            cats.Say();
            dogs.Say();

            zooManager.Show();

            Console.ReadLine();

        }
    }
}
