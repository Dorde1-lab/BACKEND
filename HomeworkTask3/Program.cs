namespace HomeworkTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle (7);
            Console.WriteLine($"Area of circle is {circle.CalculateArea()}");
            Console.WriteLine($"Perimeter of circle is {circle.CalculatePerimeter()}");

            Triangle triangle = new Triangle(4, 6, 8);
            Console.WriteLine($"Area of triangle is {triangle.CalculateArea()}");
            Console.WriteLine($"Perimeter of triangle is {triangle.CalculatePerimeter()}");


        }
    }
}
