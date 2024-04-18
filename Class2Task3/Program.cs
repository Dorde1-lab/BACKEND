namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("SwapNumbers");


            Console.Write("Your first number is:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Your second number is:");
            int secondNumber = int.Parse(Console.ReadLine());


            int swapNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = swapNumber;

            Console.WriteLine($"Now, the first number is: {firstNumber} and the second number is: {secondNumber}");

        }
    }
}
