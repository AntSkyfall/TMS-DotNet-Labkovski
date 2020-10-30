using System;

namespace HomeWork6
{
    public class User
    {

        public string name { get; set; }

        public string bodyMass { get; set; }

        public string stepLength { get; set; }

        public int numberOfSteps { get; set; }


        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Body mass: {bodyMass}");
            Console.WriteLine($"Step length: {stepLength}");
        }

        public string Calculation()
        {
            double coefSpeedEasy = 1;
            double coefSpeedAverage = 1.15;
            double coefSpeedIntense = 1.35;

            var resultEasy = coefSpeedEasy * double.Parse(bodyMass) * double.Parse(stepLength) * numberOfSteps / 100000;
            var resultAverage = coefSpeedAverage * double.Parse(bodyMass) * double.Parse(stepLength) * numberOfSteps / 100000;
            var resultIntense = coefSpeedIntense * double.Parse(bodyMass) * double.Parse(stepLength) * numberOfSteps / 100000;

            return $"-------" +
                $"\n Calories burned on an easy walk:{ resultEasy}" +
                $"\n Calories burned on an average walk:{resultAverage}" +
                $"\n Calories burned on an Intense walk:{resultIntense}";
        }

        public void Go()
        {
            Console.WriteLine("Enter number of steps");
            numberOfSteps = int.Parse(Console.ReadLine());
        }

        public User(string Name, string BodyMass, string StepLength)
        {
            name = Name;
            bodyMass = BodyMass;
            stepLength = StepLength;
        }
    }

}
