using Newtonsoft.Json;
using SerializingAndDeserializing.Entities;

namespace SerializingAndDeserializing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFirstJsonPath = "E:\\cv\\SEDC\\BACKEND\\BACKEND\\SerializingAndDeserializing\\MyFirstJson.json";
            StreamReader streamReader = new StreamReader(myFirstJsonPath);

           


            string jsonContent = string.Empty;

          
            using (streamReader)
            {
                 jsonContent = streamReader.ReadToEnd();
                Console.WriteLine(jsonContent);
            }

            Student bob = JsonConvert.DeserializeObject<Student>(jsonContent);

            Console.WriteLine("....This is C# object");
            Console.WriteLine($"{bob.FirstName} - {bob.Age}");


     






            Student zoka = new Student();
            zoka.FirstName = "Zoka";
            zoka.LastName = "Zokic";
            zoka.Age = 23;
            zoka.isPartTime = false;

            string zokaAsJson = JsonConvert.SerializeObject(zoka);

            Console.WriteLine("Zoka as Json file:");
            Console.WriteLine(zokaAsJson);










            string moviesPath = "E:\\cv\\SEDC\\BACKEND\\BACKEND\\SerializingAndDeserializing\\Movies.json";
            StreamReader streamreaderMovies = new StreamReader(moviesPath);

            string jsonContentMovies = string.Empty;


            using (streamReader)
            {
                jsonContentMovies = streamreaderMovies.ReadToEnd();

            }



            List<Movie> movies =  JsonConvert.DeserializeObject<List<Movie>>(jsonContentMovies);

            foreach(Movie item in movies)
            {
                Console.WriteLine(".....................");
                Console.WriteLine($"{item.Title}, {item.Year}");
            }

            List<Movie> ratingOver8 = movies.Where(m => m.imdbRating > 8).ToList();

            Console.WriteLine("Movies rated over 8:");

            foreach (Movie item in movies)
            {
                Console.WriteLine(".....................");                     
            }
          


        }
    }
}
