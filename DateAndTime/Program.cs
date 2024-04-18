namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Date tip podatka:

            DateTime currentDate = new DateTime(2024, 4, 16, 18, 3, 0);   // rucno podesavanje vremena, godina mesec dan sat minut sekunde
            DateTime currentDay = DateTime.Today;
            DateTime currentDateTime = DateTime.Now;

            Console.WriteLine(currentDate);
            Console.WriteLine(currentDay);
            Console.WriteLine(currentDateTime); ;



            string dateFormat1 = currentDateTime.ToString("dd/MM/yyyy");
            Console.WriteLine(dateFormat1);

            string dateFormat2 = currentDateTime.ToString("dddd, dd MMMM yyyy");   // ovako ispisuje ime dana, meseca, godine....
            Console.WriteLine(dateFormat2);

            DateTime dateAfter100Days = currentDateTime.AddDays(100);    // ispisuje dan nakon odredjenog broja dana
            Console.WriteLine(dateAfter100Days);

            DateTime dateBefore100Days = currentDateTime.AddDays(-100);    // ispisuje dan pre odredjenog broja dana
            Console.WriteLine(dateBefore100Days);

            // Postoji AddHours and Addyears;


            DateTime myBirthday = new DateTime(1995, 5, 17);

            Console.WriteLine($"Ja sam se rodio: {myBirthday}");
            Console.WriteLine($"Ja sam se rodio: {myBirthday.Year} godine");
            Console.WriteLine($"Ja sam se rodio: {myBirthday.Month} meseca");
            Console.WriteLine($"Ja sam se rodio: {myBirthday.Day} dana");
            Console.WriteLine($"Ja sam se rodio a dan u sedmici je bio {myBirthday.DayOfWeek}");







            string exercice1 = "The whole group of G1 loves G#. They find learning this language fun and easy.";
            int index1 = exercice1.IndexOf(".");

            string result = exercice1.Substring(index1 + 1, exercice1.Length - index1 - 1);
            Console.WriteLine(result);
        }
    }
}
