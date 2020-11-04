using System;
using System.Collections.Generic;

namespace HomeWork6
{
    class ListOfUsers
    {
        public List<User> dataUser = new List<User>();

        public void AddUser()
        {

            Console.Write("Enter the name of user:");
            string name = Console.ReadLine();

            Console.Write("Enter the body mass:");
            string bodyMass = Console.ReadLine();

            Console.Write("Enter the heinght:");
            var height = int.Parse(Console.ReadLine());

            dataUser.Add(new User(name, bodyMass, height));
        }

    }
}
