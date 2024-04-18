namespace Class3.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayOfNumbers = new int[6];
            int result = 0;

            for (int i = 0; i < ArrayOfNumbers.Length; i++)
            {
                Console.WriteLine("Enter your numbers:");

                if (!int.TryParse(Console.ReadLine(), out ArrayOfNumbers[i]))   // Na ovaj nacin proveravamo da li je input dobar.
                {
                    Console.WriteLine("Invalid Input");
                    i--;                                                       // Ovde korisnika vracamo da unese validan broj.
                }
            }
            foreach (int number in ArrayOfNumbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
            }
            Console.WriteLine($"The result is {result}");

        }
    }
}
