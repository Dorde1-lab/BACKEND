namespace Homework_Class_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<int> numbers = new Queue<int>();

            int counter = 0;
            while(counter < 7)
            {
                Console.WriteLine("Could you input a number:");
                numbers.Enqueue(Convert.ToInt32(Console.ReadLine()));
                counter++;
            }
            Console.WriteLine("Would you like to add another number? ('1. yes' '2. no')");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Add a number:");
                    numbers.Enqueue(Convert.ToInt32(Console.ReadLine()));
                    break;
                case "2":
                    Console.WriteLine("Wait a next step.");
                    break;
                default:
                    Console.WriteLine("Wait a next step.");
                    break;
            }

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }



        }
    }
}
