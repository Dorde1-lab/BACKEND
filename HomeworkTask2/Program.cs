namespace HomeworkTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle(10);
            Console.WriteLine(circle.GetArea());


            Rectangle rectangle = new Rectangle(5, 6);
            Console.WriteLine(rectangle.GetArea());

            Triangle triangle = new Triangle(7, 8);
            Console.WriteLine(triangle.GetArea());
        }
    }
}
