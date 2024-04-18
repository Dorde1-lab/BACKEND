using ClassOOP.Dog;

namespace ClassesOOPClass7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dog's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the dog's race:");
            string race = Console.ReadLine();

            Console.WriteLine("Enter the dog's color:");
            string color = Console.ReadLine();

            Dog MyDog = new Dog(name, race, color);

            Console.WriteLine("\n Chose an action for your dog(eat, play, chase)");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case 'eat':
                    Console.WriteLine(MyDog.Eat());
                    break;

                case 'play':
                    Console.WriteLine(MyDog.Play());
                    break;

                case 'chase':
                    Console.WriteLine(MyDog.ChaseTail());
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }




        }
    }
}
