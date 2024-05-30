using System.Collections.Generic;

namespace Homework1Static
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<User> userByName = UserDatabase.Search(name: "Mirko");
            PrintUsers(userByName);

            List<User> userById = UserDatabase.Search(id: 1);
            PrintUsers(userById);

            List<User> userByAge = UserDatabase.Search(age: 33, name: "Marko");
            PrintUsers(userByAge); 
         

        }




        static void PrintUsers(List<User> users)
        {
            foreach (User user in users)
            {
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
            }
        }

    }
}
