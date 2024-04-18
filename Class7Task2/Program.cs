using Class7Task2.Models;

namespace Class7Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you enter user's first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Can you enter user's last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Can you enter user's age");
            int age = int.Parse(Console.ReadLine());


            Human person1 = new Human(firstName, lastName, age);

            Console.WriteLine(person1.GetPersonStats());
        }
    }
}
