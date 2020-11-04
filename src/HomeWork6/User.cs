using System;

namespace HomeWork6
{
    public class User
    {

        public string name { get; set; }

        public string bodyMass { get; set; }

        public int Height { get; set; }

        public int numberOfSteps { get; set; }


        //public static int StepLenght(int Height) => StepLenght = (Height / 4) + 37;


        public string Calculation()
        {
            double coefSpeedEasy = 1;
            double coefSpeedAverage = 1.15;
            double coefSpeedIntense = 1.35;

            var stepLength = (Height / 4) + 37;
            Console.WriteLine($"Step lenght = {stepLength} cm");

            var resultEasy = coefSpeedEasy * double.Parse(bodyMass) * stepLength * numberOfSteps / 100000;
            var resultAverage = coefSpeedAverage * double.Parse(bodyMass) * stepLength * numberOfSteps / 100000;
            var resultIntense = coefSpeedIntense * double.Parse(bodyMass) * stepLength * numberOfSteps / 100000;

            return $"-------" +
                $"\n Calories burned on an easy walk:{ resultEasy}" +
                $"\n Calories burned on an average walk:{resultAverage}" +
                $"\n Calories burned on an Intense walk:{resultIntense}";
        }

        public void GetInfo()
        {
            Console.WriteLine($"------ \n Name: {name}");
            Console.WriteLine($"Body mass: {bodyMass}");
            Console.WriteLine($"Height: {Height}");
        }

        public void Go()
        {
            Console.WriteLine("Enter number of steps");
            numberOfSteps = int.Parse(Console.ReadLine());
        }

        public User(string Name, string BodyMass, int height)
        {
            name = Name;
            bodyMass = BodyMass;
            Height = height;
        }
    }

}
