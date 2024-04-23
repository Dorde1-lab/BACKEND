namespace Class3Task2
{
    internal class Program
{
    static void Main(string[] args)
    {
        string[] studentsG1 = new string[]
        {
                "Zdravko", "Petko", "Stanko", "Branko", "Trajko"
        };

        string[] studentsG2 = new string[]
        {
                "Marija", "Maja", "Ana", "Ivana", "Jovana"
        };

        Console.WriteLine("Select a number of array (1 or 2)  you want to display");
        int option = Convert.ToInt32(Console.ReadLine());

        if (option == 1)
        {
            Console.WriteLine($"The students in G1 are:");

            foreach (string student1 in studentsG1)
            {
                Console.WriteLine(student1);
            }
        }
        if (option == 2)
        {
            Console.WriteLine($"The students in G2 are:");

            foreach (string student2 in studentsG2)
            {
                Console.WriteLine(student2);
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
}
