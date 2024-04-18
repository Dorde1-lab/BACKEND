namespace Class4Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please, write you date of birth(yyyy/MM/dd):");
            DateTime bDay = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(AgeCalculator(bDay));

        }

        static int AgeCalculator(DateTime bDay)
        {
            int myAge = DateTime.Today.Year - bDay.Year;
            if (DateTime.Today.Month < bDay.Month || DateTime.Today.Month == bDay.Month && DateTime.Today.Day < bDay.Day)
            {
                myAge--;
            }
            return myAge;
        }
    }
}
