namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Real Calculator");

            Console.WriteLine("Enter the first number:");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Can you choose an operation(+, -, *, /)");
            char operation = Console.ReadKey().KeyChar;                      // Ovom metodom sistem "cita" operatore.

            Console.WriteLine("_______________________");

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("invalid input(try to avoid 0).");
                        return;
                    }
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("invalid operation. Please choose a valid operation.");
                    return;
            }

            Console.WriteLine($"Result is: {result}");

        }
    }
}
