namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> personList = new List<Person>
            {
                new Person { FirstName = "Alice", LastName = "Smith", Age = 25, Country = "USA", Hobbies = new List<string> { "Reading", "Hiking" } },
                new Person { FirstName = "Bob", LastName = "Johnson", Age = 30, Country = "Canada", Hobbies = new List<string> { "Cooking", "Painting" } },
                new Person { FirstName = "Charlie", LastName = "Brown", Age = 22, Country = "UK", Hobbies = new List<string> { "Swimming", "Gaming" } },
                new Person { FirstName = "David", LastName = "Wilson", Age = 27, Country = "USA", Hobbies = new List<string> { "Photography", "Gardening" } },
                new Person { FirstName = "Emily", LastName = "Davis", Age = 28, Country = "Canada", Hobbies = new List<string> { "Traveling", "Yoga" } },
                new Person { FirstName = "John", LastName = "Smith", Age = 35, Country = "USA", Hobbies = new List<string> { "Reading", "Cooking", "Hiking" } },
                new Person { FirstName = "Jane", LastName = "Doe", Age = 32, Country = "Canada", Hobbies = new List<string> { "Reading", "Gaming" } },
                new Person { FirstName = "Michael", LastName = "Brown", Age = 24, Country = "UK", Hobbies = new List<string> { "Swimming", "Hiking" } },
                new Person { FirstName = "Daniel", LastName = "Wilson", Age = 30, Country = "USA", Hobbies = new List<string> { "Gardening", "Singing" } },
                new Person { FirstName = "Emma", LastName = "Johnson", Age = 29, Country = "Canada", Hobbies = new List<string> { "Yoga", "Cooking" } },
                new Person { FirstName = "Olivia", LastName = "Smith", Age = 23, Country = "USA", Hobbies = new List<string> { "Reading", "Gardening" } },
                new Person { FirstName = "James", LastName = "Davis", Age = 26, Country = "Canada", Hobbies = new List<string> { "Traveling" } },
                new Person { FirstName = "Noah", LastName = "Brown", Age = 29, Country = "UK", Hobbies = new List<string> { "Swimming", "Gaming" } },
                new Person { FirstName = "Ella", LastName = "Wilson", Age = 28, Country = "USA", Hobbies = new List<string> { "Photography", "Cooking" } },
                new Person { FirstName = "Liam", LastName = "Davis", Age = 31, Country = "Canada", Hobbies = new List<string> { "Reading", "Yoga" } }
            };

            // Find the preson with name Michael and lastname Brown


            //  where vraca listu, firstordefault vraca prvi element na koji naidje: Znaci:
            Person michaelBrown = personList.Where(p => p.FirstName == "Michael" && p.LastName == "Brown").FirstOrDefault();

            Console.WriteLine($"{michaelBrown.FirstName}, {michaelBrown.LastName}, {michaelBrown.Age}");


            // Da hocemo listu, onda bi na karju napisali toList() i promenili bi tip podatka michaelBrown;

            Person michaelBrown2 = personList.FirstOrDefault(p => p.FirstName == "Michael" && p.LastName == "Brown"); 

            Console.WriteLine($"{michaelBrown2.FirstName}, {michaelBrown2.LastName}, {michaelBrown2.Age}");


            Console.WriteLine("_____________________");



            // Find all person with age betwenn 20 and 27. sort then descending.

            List<Person> ageBetween20And27 = personList
                .Where(p => p.Age >= 20 && p.Age <= 27)
                .OrderByDescending(p => p.Age)                   // orderBy (po difoltu radi u rastucem smeru. a mozemo i precizirati orderByDescending)
                .ToList();

            Console.WriteLine("People with age 20 - 27");

            foreach(Person person in ageBetween20And27)
            {
                Console.WriteLine($"{person.FirstName} - {person.LastName} - {person.Age}");
            }


            Console.WriteLine("_____________________");


            // Find the oldest person

            Person oldestPerson = personList              // ovde oldestPerson predstavlja referencu na vec postojeci objekat u ovoj listi. 
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();

            Console.WriteLine($"The oldest person is {oldestPerson.FirstName} - {oldestPerson.Age}");

            

            Console.WriteLine("_____________________");


            Person oldestPerson2 = personList
                .OrderByDescending(p => p.Age)
                .LastOrDefault();

            Console.WriteLine($"The oldest person is {oldestPerson.FirstName} - {oldestPerson.Age}");


            // Find all first names from people from USA and sort them by age descending


          List<string> firstNamesFromUSA = personList
                .Where(p => p.Country == "USA")
                .OrderByDescending(p => p.Age)
                .Select(p => p.FirstName)
                .ToList();

            Console.WriteLine("People from USA:");

            foreach(string item in firstNamesFromUSA)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("_____________________");




            // find average age :



            double averageAge = personList
                .Average(p => p.Age);                                                    // metoda Average trazi prosecnu vrednost necega (ovde godina);


            int minAge = personList
               .Min(p => p.Age);

            int maxAge = personList
                .Max(p => p.Age);

            int count = personList.Count();

            Console.WriteLine($"Count of items: {count}, average age is {averageAge}, the youngest {minAge} and the oldest age is {maxAge}");






            // .Average
            // .Min
            // .Max

            // Where
            // Select
            // OrderBy
            // OrderByDescending
            // FirstOrDefault
            // First
            // Last

            // Count - Ukupan broj nekih elementa
            // Take(3) - uzmi odredjeni broj clanova 
            // Length 
            // Contains
            // DistinctBy

            // Any -  bool - vraca true or false
            // All - selektuje sve clanove 

            // ThenByDescending - (ako je prethodni uslov isti za dva ili vise clanova) sortiraj po .....///




            // find 5 oldest ones from list:


            List<Person> fiveOldestOnes = personList
                .OrderByDescending(p => p.Age)
                .ThenByDescending(p => p.LastName)                                               // ako se desi da imaju isto godina onda sortiraj po prezimenu. Metoda ThenBy !!!
                .Take(5)                             // uzima onoliko koliko mi specificiramo.
                .ToList();


            Console.WriteLine("Top 5 oldest ones:");

            foreach (Person item in fiveOldestOnes)
            {
                Console.WriteLine($"{item.FirstName}  {item.LastName} - {item.Age}");
            }


            Console.WriteLine("_____________________");


            // Find person with longest first name

            Person longestFirstName = personList
                .OrderByDescending(p => p.FirstName.Length)
                .FirstOrDefault();

            Console.WriteLine($"People with longest first name is {longestFirstName.FirstName}");



            // find all persons with hobby Yoga

            List<Person> peopleWithYogaHobby = personList
                .Where(p => p.Hobbies.Contains("Yoga"))
                .ToList();


            foreach(Person person in peopleWithYogaHobby)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }


            Console.WriteLine("_____________________");




            // Print only first and last name from all people

            List<string> fullName = personList
                .Select(p => p.FirstName + " " + p.LastName)               // select uglavnom za parcijalno uzimanje iz kompleksnog tipa.
                .ToList();

            Console.WriteLine("People full names:");


            foreach (string item in fullName)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("_____________________");






            bool personFromBiH = personList
                .Any(p => p.Country == "Bosnia and Herzegovina");


            bool olderThan40 = personList
                .Any(p => p.Age > 40);

            bool personWhoLikesYoga = personList
                .Any(p => p.Hobbies.Contains("Yoga"));







            Console.WriteLine("__________1___________");



            List<Person> fromUSA = personList
                .Where(p => p.Country == "USA")
                .ToList();

            Console.WriteLine("People from USA:");

            foreach (Person person in fromUSA)
                Console.WriteLine(person.FirstName);







            Console.WriteLine("__________2___________");


            List<Person> oldest = personList
                .OrderByDescending(p => p.Age)
                .Take(1)
                .ToList();


            Console.WriteLine("The oldest person is:");

            foreach(Person person in oldest)
                Console.WriteLine(person.FirstName + " " + person.LastName);








            Console.WriteLine("__________3___________");


            Console.WriteLine("Average age is:");

            double average = personList
                .Average(p => p.Age);

            Console.WriteLine(average);







            Console.WriteLine("__________4___________");


            List<string> NamesWithJ = personList
                .Where(p => p.FirstName.StartsWith("J"))
                .Select(p => p.FirstName)
                .ToList();

            Console.WriteLine("Person with a name J:");

                foreach(string name in NamesWithJ)
            {
                Console.WriteLine(name);
            }






            Console.WriteLine("__________5___________");


            List<Person> yongest = personList
                .OrderBy(p => p.Age)
                .Take(3)
                .ToList();

            Console.WriteLine("Three yongest persons are:");

            foreach(Person person in yongest)
            {
                Console.WriteLine(person.FirstName);
            }





            Console.WriteLine("__________6___________");



            bool anyHobby = personList
                .Any(p => p.Hobbies.Contains("Reading"));               // mora contains jer je to lista

            Console.WriteLine(anyHobby);







            Console.WriteLine("__________7___________");



           List<string> unique = personList
                .DistinctBy(p => p.Country)
                .Select(p => p.Country)
                .ToList();

            Console.WriteLine("Unique country are:");


            foreach(string country in unique)
            {
                Console.WriteLine(country);
            }






            Console.WriteLine("__________8___________");


            List<Person> ages = personList
               .OrderBy(p => p.Age)
               .ToList();

            Console.WriteLine("Persons in ascending order are:");

            foreach (Person person in ages)
            {
                Console.WriteLine(person.FirstName + " " + person.Age);
            }






            Console.WriteLine("__________9___________");


            List<Person> years30 = personList
                .Where(p => p.Age == 30)
                .ToList();

            foreach (Person person in years30)
            {
                Console.WriteLine($"Persons who are exacly 30 years old are: {person.FirstName}");
            }





            Console.WriteLine("__________10___________");


            List<string> peopleFromUK = personList
                .Where(p => p.Country == "UK")
                .Select (p => p.FirstName)
                .ToList();

            foreach (string person in peopleFromUK)
            {
                Console.WriteLine(person);
            }






            Console.WriteLine("__________11___________");



            bool allPerson = personList.All(p => p.Hobbies != null && p.Hobbies.Any());                     // All - Any

            Console.WriteLine(allPerson);



            // moze i ovako 

            bool allHaveHobbies = personList
                .Select(p => p.Hobbies)
                .All(hobbies => hobbies != null && hobbies.Any());




            //  da li postoji bilo koja osoba bez hobija ...

            bool noOneHaveHobbies = personList.Count(p => p.Hobbies == null || !p.Hobbies.Any()) == 0;






            Console.WriteLine("__________12___________");



            List<Person> twoHobbies = personList
                .Where(p => p.Hobbies.Contains("Singing") && p.Hobbies.Contains("Dancing"))
                .ToList();


            foreach(Person person in twoHobbies)
            {
                Console.WriteLine($"Persons with the hobbies singing and dancing are: {person.FirstName} - {person.Hobbies}");
            }






            Console.WriteLine("__________13___________");



            Person longestFirstNames = personList
                .OrderByDescending(p => p.FirstName.Length)
                .FirstOrDefault();

            Console.WriteLine(longestFirstNames);


            Person longestLastNames = personList
               .OrderByDescending(p => p.LastName.Length)
               .FirstOrDefault();

            Console.WriteLine(longestLastNames);





            Console.WriteLine("__________14___________");



            List<string> allPeople = personList
                .Select(p => p.FirstName + " " + p.LastName)
                .ToList();

            foreach (string person in allPeople)
            {
                Console.WriteLine(person);
            }

        }
    }
}
