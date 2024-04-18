namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            int number4 = int.Parse(Console.ReadLine());



            int average = (number1 + number2 + number3 + number4) / 4;

            Console.WriteLine($"The result is: {average}");
        }
    }
}


//  double num1, num2, num3;

//  if (!double.TryParse(Console.WriteLine(), out num1){
//  Console.WriteLine("Invalid input");
//  return;
//  }