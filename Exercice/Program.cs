using Exercice;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Can you enter your full name?");
            string name = Console.ReadLine();

            Console.WriteLine("Can you enter your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello {name}, you are {age} old.");





            Console.WriteLine("_______________________________________");



            Console.WriteLine("Could you enter a number?");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
                Console.WriteLine("Negative number");
            if (number > 0)
                Console.WriteLine("Positive number");
            if (number == 0)
                Console.WriteLine("Zero");

            Console.WriteLine("_______________________________________");


            // ne valja kod :D

            int sum = 0;
            int baseNumber = 1;

            Console.WriteLine("Could you enter a number?");
            int inputNumber = int.Parse(Console.ReadLine());


            int[] numbersArray = new int[inputNumber + 1];

            while (baseNumber <= inputNumber)
            {
                numbersArray[baseNumber] = inputNumber;
                if (numbersArray[baseNumber] % 2 == 0)
                {
                    sum += baseNumber;
                }
                baseNumber++;
            }
            Console.WriteLine(sum);




            Console.WriteLine("_______________________________________zadatak 3");






            Console.WriteLine("_______________________________________zadatak 4");


            Person Jerry = new Person("Jerry", 78, "Male");
            Person Stefan = new Person("Stefan", 28, "Male");
            Person Maria = new Person("Maria", 43, "Female");
            Person Jane = new Person("Jane", 28, "Female");
            Person Jack = new Person("Jack", 44, "Male");

            List<Person> PersonArray = new List<Person>();

            PersonArray.Add(Jerry);
            PersonArray.Add(Stefan);
            PersonArray.Add(Maria);
            PersonArray.Add(Jane);
            PersonArray.Add(Jack);



            List<Person> people = PersonArray
                .Where(item => item.Age > 30).ToList();

            Console.WriteLine("People older than 30 years are:");

            foreach (Person personName in people.OrderByDescending(x => x.Age))
            {
                Console.WriteLine(personName.Name);
                Console.WriteLine($"The name is: {personName.Name} and the age is:{personName.Age}");
            }



            */





            Console.WriteLine("_____________________HOMEWORK_________________");




            List<Book> books = new List<Book>
            {
                new Book { Title = "Book1", Author = "Author1", Year = 2010},
                new Book { Title = "Book2", Author = "Author2", Year = 2005},
                new Book { Title = "Book3", Author = "Author3", Year = 2018},
                new Book { Title = "Book4", Author = "Author1", Year = 2020},

            };

            List<Book> Author1 = books.Where(item => item.Author == "Author1").ToList();

            foreach(Book namesofAuthor in Author1)
            {
                Console.WriteLine(namesofAuthor.Title);
            }

           
           
            foreach(Book publicationYear in books.OrderByDescending(x => x.Year))
            {
                Console.WriteLine($"Publication year of books are: {publicationYear.Year}");
            }



            List<string> titlesOfBooks = books.Select(item => item.Title).ToList();

            foreach(string nameOfBooks in titlesOfBooks)
            {
                Console.WriteLine(nameOfBooks);
            }





        }

    }
}
