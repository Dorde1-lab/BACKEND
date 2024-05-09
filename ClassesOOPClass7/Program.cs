using Class7Task1.Models;
using ClassOOP.Dog;
using System.Security.Cryptography;

namespace ClassesOOPClass7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
             
            // ...............................................................................Task 1 - Dog


            Console.WriteLine("Enter the dog's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the dog's race:");
            string race = Console.ReadLine();

            Console.WriteLine("Enter the dog's color:");
            string color = Console.ReadLine();

            Dog MyDog = new Dog(name, race, color);

            Console.WriteLine("\n Chose an action for your dog(1. eat, 2. play, 3. chase)");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(MyDog.Eat());
                    break;

                case "2":
                    Console.WriteLine(MyDog.Play());
                    break;

                case "3":
                    Console.WriteLine(MyDog.ChaseTail());
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            */

            //  ........................................................... Task 2 - Human

            /*

            Console.WriteLine("Can you enter user's first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Can you enter user's last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Can you enter user's age");
            int age = int.Parse(Console.ReadLine());


            Human person1 = new Human(firstName, lastName, age);

            Console.WriteLine(person1.GetPersonStats());

            */

            // ..........................................................Task 3 - 



            Student[] Students = new Student[5];        // Ovde pravimo niz objekata klase Student. Zato je Student[] !!!    niz od 5 objekata!!!!

            for (int i = 0; i < Students.Length; i++)
            {

                Console.WriteLine("Enter student's full name:");
                string nameInput = Console.ReadLine();

                Console.WriteLine("Enter student's academy name:");
                string academyInput = Console.ReadLine();

                Console.WriteLine("Enter student's group name:");
                string groupInput = Console.ReadLine();


                Student objStudent = new Student(nameInput, academyInput, groupInput);  //  konstruktor


                Students[i] = objStudent;
            }


            Console.WriteLine("Search a name you want:");
            string namesearched = Console.ReadLine().ToLower();


            bool trueOrFalse = false;

            foreach(Student item in Students)    // Student je objekat kao tip podatka
            {
                if(item.Name.ToLower() == namesearched)
                {
                    Console.WriteLine($"{item.Name} {item.Academy} {item.Group}");
                    trueOrFalse = true;
                }
            }
            if(trueOrFalse == false)
            {
                Console.WriteLine("There is no user with that name.");
            }

       

        }
    }
}



       