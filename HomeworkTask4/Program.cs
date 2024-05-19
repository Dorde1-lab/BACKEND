namespace HomeworkTask4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Manager manager = new Manager("Marko", 4, 2000, 7000);
            manager.DisplayInfo();

            Programmer programmer = new Programmer("Milos", 1, 80, 260);
            programmer.DisplayInfo();
        }
    }
}
