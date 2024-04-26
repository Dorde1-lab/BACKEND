using System.Collections.ObjectModel;

namespace CollectionInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> StudentNames = new List<string>();

            StudentNames.Add("Djordje");
            StudentNames.Add("Milica");
            StudentNames.Add("Tamara");
            StudentNames.Add("Sava");
            StudentNames.Add("Goran");

            StudentNames.Remove("Goran");                                               // Remove an element from list;

            Console.WriteLine("Student Names:");

            foreach(string name in StudentNames)
            {
                Console.WriteLine(name);
            }

            string search = "Tamara";

            if (StudentNames.Contains(search))                                           // Metoda Contains
            {
                Console.WriteLine($"There is a student with name: {search}");
            }

            Console.WriteLine($"There is {StudentNames.Count} elements in this list");     // Metoda Count - izbacuje broj elementa u listi.

            List<int> numbers = new List<int>() { 10, 10, 20, 30, 44, 1000, 43243 };             // inicijalizacija liste    !!!!!!!!!!!

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"On position 3 there is a numebr: {numbers[2]}");         
            Console.WriteLine($"On postion 5 there is a number: {numbers.ElementAt(4)}");       // Element na odredjenoj poziciji

            numbers.RemoveAt(1);                                                             // Brisanje elementa na odredjenoj poziciji
            Console.WriteLine($"On position 2 there is a number: {numbers[1]}");

          
            //  Add();
            // Remove();
            // Contains().
            // Count;             !!!!!!!!!!!!!!!!!!!1
            // ElementAt[];
            // RemoveAt[];








            Console.WriteLine("_______________________________DICTIONARY_____________________________________");


            Dictionary<string, int> studentsGrades = new Dictionary<string, int>();

            studentsGrades.Add("Djordje", 10);
            studentsGrades.Add("Milica", 10);
            studentsGrades.Add("Tamara", 10);
            studentsGrades.Add("Goran", 10);
            studentsGrades.Add("Sava", 10);

            Console.WriteLine("Student's grades:");
            foreach(KeyValuePair<string, int> grade in studentsGrades)
            {
                Console.WriteLine($"Student: {grade.Key} - ocena: {grade.Value}");
            }


            if (studentsGrades.ContainsKey("Milica"))            // containsKey
            {
                Console.WriteLine("Therte is a student called milica");
            }

            if (studentsGrades.ContainsValue(10))         //ContainsValue;
            {
                Console.WriteLine($"There is {studentsGrades.Count} key value pairs in this dictionary");       // Count

                Console.WriteLine($"Student Milica has grade:{studentsGrades["Milica"]}");     // ispisuje value od milica
            }

            Dictionary<string, bool> todoList = new Dictionary<string, bool>()
            {
                { "Wash a car", false},
                { "Get groceries", true},
                { "Write homework", true}
            };


            // Add();
            // ContainsKey();
            // ContainsValue();
            // Count;

     






            Console.WriteLine("____________________QUEUE_________________________");



            Queue<string> queueInShop = new Queue<string>();

            queueInShop.Enqueue("Goran (prvi dosao)");
            queueInShop.Enqueue("Milica (drugi dosao)");
            queueInShop.Enqueue("Tamara (treci dosao)");

            foreach (string element in queueInShop)
                Console.WriteLine(element);

            queueInShop.Dequeue();
            Console.WriteLine($"Klijent je platio... idemo dalje {queueInShop.Peek()} je na redu");

            foreach (string element in queueInShop)
                Console.WriteLine(element);

            queueInShop.Dequeue();
            Console.WriteLine($"Klijent je platio... idemo dalje {queueInShop.Peek()} je na redu");

            foreach (string element in queueInShop)
                Console.WriteLine(element);


            //  Enqueue();
            // Dequeue();
            // NameOfQueue.Peek();  -  Pokazuje trenutni element u queue !!!





            Console.WriteLine("_____________________STACK_______________________");


            Stack<string> cookies = new Stack<string>();

            cookies.Push("Prvi keks");
            cookies.Push("Drugi keks");
            cookies.Push("Treci keks");
            cookies.Push("Cetvrti keks");
            cookies.Push("Peti keks");


            Console.WriteLine("Cookies: ");
            foreach (string element in cookies)
            {
                Console.WriteLine(element);
            }
            cookies.Pop();
            Console.WriteLine($"Kekes je izvadjen.. idemo dalje naredni je {cookies.Peek}");


            Console.WriteLine("Cookies:");
            foreach (string element in cookies)
            {
                Console.WriteLine(element);
            }  

            cookies.Pop();
            cookies.Pop();

            Console.WriteLine($"Dva keka su izvadjena.. idemo dalje, naredni je {cookies.Peek}");

            Console.WriteLine("Cookies:  ");
            foreach (string element in cookies)
                Console.WriteLine(element);







            Console.WriteLine("________________________________________");

            



                List<string> students = new List<string>()
            {
                "Tamara", "Sava", "Goran", "Milica", "John", "Manuel", "Stefan", "Almir"
            };

                foreach (string studentName in students)
                {
                    if (studentName.Length == 4)
                        Console.WriteLine($"Ovaj student ima 4 slova u svom imenu {studentName}");
                }

                // Manual approach
                List<string> studentsWith5Letters = new List<string>();

                foreach (string studentName in students)
                {
                    if (studentName.Length == 5)
                        studentsWith5Letters.Add(studentName);
                }


                // LINQ approach
         


                //  WHERE       -  filtrira 

                List<string> studentsWithFiveLetters = students
                    .Where(item => item.Length == 5)
                    .ToList();


                Console.WriteLine("Pet slova u svom imenu");
                foreach (string studentName in studentsWithFiveLetters)
                    Console.WriteLine(studentName);




                // SELECT       -  ne vrsi filtriranje, samo mapira i transformise elemente

                List<int> studentNameLengths = students
               .Select(item => item.Length)
               .ToList();


            // FIRST  and  LAST

            Person stefanPerson = FansArray
           .Where(p => p.FirstName == "Stefan" && p.Age == 26)
           .First();    //  vrati prvu pojavu sa ovim parametrima.
             

        }
    }
}
