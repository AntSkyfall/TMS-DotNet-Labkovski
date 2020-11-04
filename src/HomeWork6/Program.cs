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


            foreach (User user in users.dataUser)
            {
                user.Go();
                user.GetInfo();
                Console.WriteLine(user.Calculation());
            }
        }

    }

}

