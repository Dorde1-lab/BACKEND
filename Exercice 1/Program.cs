using System.Linq;
using System.Xml.Linq;

namespace Exercice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //........................................................................... Zadatak 1


            Dictionary<string, long> phoneBook = new Dictionary<string, long>();


            phoneBook.Add("Djordje", 33);
            phoneBook.Add("Marija", 5500111);
            phoneBook.Add("Ivana", 000111111);
            phoneBook.Add("Danijela", 000111111);
            phoneBook.Add("Ivan", 000111111);

            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();

            PrintPhone(phoneBook, name);

            Console.WriteLine("__________________________________________________________");

            //........................................................................... Zadatak 2

            List<Person> FansArray = new List<Person>();

            //fans
            Person Jerry = new Person("Jerry", "Tompson", 78, GenreEnum.Rock);
            Person Stefan = new Person("Stefan", "Stefanoski", 28, GenreEnum.Techno);
            Person Maria = new Person("Maria", "Campbel", 43, GenreEnum.Classical);
            Person Jane = new Person("Jane", "Doe", 28, GenreEnum.Techno);


            FansArray.Add(Jerry);
            FansArray.Add(Stefan);
            FansArray.Add(Maria);
            FansArray.Add(Jane);


            //songs
            Song song1 = new Song("Bohemian Rhapsody", 367, GenreEnum.Rock);
            Song song2 = new Song("Stairway To Heaven", 480, GenreEnum.Rock);
            Song song3 = new Song("Riders On The Storm", 430, GenreEnum.Rock);
            Song song4 = new Song("Not Fade Away", 108, GenreEnum.Rock);
            Song song5 = new Song("Breaking Glass", 111, GenreEnum.Rock);
            Song song6 = new Song("Welcome To The Jungle", 275, GenreEnum.Rock);
            Song song7 = new Song("Walk Of Life", 266, GenreEnum.Rock);
            Song song8 = new Song("Smoke on the Water", 340, GenreEnum.Rock);
            Song song9 = new Song("93 'til Infinity", 209, GenreEnum.Techno);
            Song song10 = new Song("Fight the Power", 321, GenreEnum.Techno);
            Song song11 = new Song("The Message", 363, GenreEnum.Techno);
            Song song12 = new Song("Butterfly Effect", 213, GenreEnum.Techno);
            Song song13 = new Song("No Fear", 182, GenreEnum.Techno);
            Song song14 = new Song("Hereditary", 340, GenreEnum.Techno);
            Song song15 = new Song("Bounce Back", 226, GenreEnum.Techno);
            Song song16 = new Song("The Four Seasons", 2520, GenreEnum.Classical);
            Song song17 = new Song("Canon in D major", 376, GenreEnum.Classical);
            Song song18 = new Song("Swan Lake", 461, GenreEnum.Classical);
            Song song19 = new Song("Symphony No. 5", 425, GenreEnum.Classical);
            Song song20 = new Song("Ride of the Valkyries", 608, GenreEnum.Classical);
            Song song21 = new Song("The Magic Flute", 458, GenreEnum.Classical);
            Song song22 = new Song("Carmen Suite No.1", 721, GenreEnum.Classical);
            Song song23 = new Song("Planet E", 420, GenreEnum.Techno);
            Song song24 = new Song("Phasor", 368, GenreEnum.Techno);
            Song song25 = new Song("Counting Comets", 242, GenreEnum.Techno);
            Song song26 = new Song("Cold Summer", 358, GenreEnum.Techno);
            Song song27 = new Song("Destroyer", 359, GenreEnum.Techno);
            Song song28 = new Song("Phalanx", 160, GenreEnum.Hip_Hop);
            Song song29 = new Song("Vision", 693, GenreEnum.Techno);
            Song song30 = new Song("Chain Reaction", 181, GenreEnum.Techno);


            List<Song> Songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7, song8, song9, song10, song11, song12, song13, song14, song15,
            song16, song17, song18, song19, song20, song21, song22, song23, song24, song25, song26, song27, song28, song29, song30 };




            // Zadatak 3





         // Select the person Jerry and add all the songs which start with  the letter B


            Person person1 = FansArray.Where(item => item.FirstName == "Jerry").First();

            if (person1 != null)
            {
                List<Song> songsStartingWithB = Songs.Where(item => item.Title.StartsWith("B")).ToList();

                foreach (Song searchedSong in songsStartingWithB)
                {
                    person1.FavoriteSongs.Add(searchedSong);
                }

                Console.WriteLine("Songs starting with 'B' are:");
                foreach (Song nameOfSong in person1.FavoriteSongs)
                {
                    Console.WriteLine(nameOfSong.Title);
                }

            }
            else
                Console.WriteLine("Jerry not found");

            Console.WriteLine("__________________________________________________________");




         // Select the person Maria and add all the songs with length  longer than 6 min


            Person person2 = FansArray.Where(item => item.FirstName == "Maria").First();

            if (person2 != null)
            {
                List<Song> lengthOfSong = Songs.Where(item => item.Length > 360).ToList();

                foreach (Song searchedSongs in lengthOfSong)
                {
                    person2.FavoriteSongs.Add(searchedSongs);
                }
                Console.WriteLine("Songs langer than 6 min are:");

                foreach (Song nameOfSong in person2.FavoriteSongs)
                {
                    Console.WriteLine(nameOfSong.Title);
                }
            }
            else
                Console.WriteLine("No songs longer than 3 minutes.");

                Console.WriteLine("__________________________________________________________");




         // Select the person Jane and add all the songs that are of genre Rock


                Person person3 = FansArray.Where(item => item.FirstName == "Jane").First();

                List<Song> genreOfSongs = Songs.Where(item => item.Genre == GenreEnum.Rock).ToList();

                foreach(Song searchedSongs in genreOfSongs)
                {
                    person3.FavoriteSongs.Add(searchedSongs);
                }

                Console.WriteLine("Rock songs are:");
                foreach(Song nameOfSong in person3.FavoriteSongs)
                {
                    Console.WriteLine(nameOfSong.Title);
                }
                Console.WriteLine("__________________________________________________________");





        // Select the person Stefan and add all songs shorter than 3 min and of genre Hip - Hop.


            Person person4 = FansArray.Where(item => item.FirstName == "Stefan").First();


            List<Song> shorterSongs = Songs.Where(item => item.Length < 180 && item.Genre == GenreEnum.Hip_Hop).ToList();

            foreach(Song searchedSongs in shorterSongs)
            {
                person4.FavoriteSongs.Add(searchedSongs);
            }

            Console.Write("Songs sorter than 3 minutes witch genre is Hip-Hip are:");
            foreach(Song nameOfSongs in person4.FavoriteSongs)
            {
                Console.WriteLine(nameOfSongs.Title);
            }
            Console.WriteLine("__________________________________________________________");




            // Select all persons from the persons array that have 4 or more  songs.


            Person[] allPersons = new Person[] { person1, person2, person3, person4 };


            bool validation = false;

            Console.WriteLine($"Persons with 4 or more songs are:");

            foreach (Person person in allPersons)
            {
                if (person.FavoriteSongs.Count >= 4)
                {
                    validation = true;
                    Console.WriteLine(person.FirstName);
                }       
            }
                if (!validation)
                Console.WriteLine("No people");


        }









        static void PrintPhone(Dictionary<string, long> phoneBook, string? name)    // ovaj znak pitanja znaci da ta promenljiva moze biti null
            {                                                                               // funkcija moze vracati null ili var moze biti null kao pocetnu vrednost.
                if (phoneBook.ContainsKey(name) == false)                                   // null sluzi za definisanje ponasanja, prevenciju gresaka, sigurnost u izvrsavanju koda
                {
                    Console.WriteLine($"There is no {name} in this phoneBook. Sorry!");
                    return;
                }

                Console.WriteLine($"{name}'s phone is: 0{phoneBook[name]}");
            }

            /*
            public static string MojaMetoda( )               // Ovde umesto string moze biti i ime klase npr. Person. jer je to tip podatka.
            {
                return null;
            }
        */
        }
    }

