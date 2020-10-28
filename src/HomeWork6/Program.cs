using System;
using System.Security.Cryptography.X509Certificates;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {

            ListOfUsers users = new ListOfUsers();

            users.AddUser();

            // Тут можно было использовать магию, но не хватило времени ее найти((
            foreach (User user in users.dataUser)
            {
                user.Go();
                user.GetInfo();
                Console.WriteLine($"Calories burned on an easy walk: {user.Calculation()}");
            }
        }

    }

}

