using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    public class Person
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public GenreEnum FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }    // tip podatka List. A song je objekat isto kao tip podatka


        public Person(string FirstName,  string LastName, int Age, GenreEnum FavoriteMusicType)
        {
            this.FirstName = FirstName;
            this. LastName = LastName;
            this.Age = Age;
            this.FavoriteMusicType = FavoriteMusicType;
            this.FavoriteSongs = new List<Song>();
        }



        public string nameOfPerson()
        {
            return FirstName + " " + LastName;
        }



       public void GetFavSongs()
        {
            if(FavoriteSongs.Count > 0)
            {
                foreach (Song song in FavoriteSongs)                                  // umesto Song song, moze se pisati var song, C# ce automatski shvatiti  
                    Console.WriteLine($"{song.Title} {song.Length} {song.Genre}");   //  o kom tipu podatka se radi na osnovu tipa podataka u FavoriteSongs
            }
            else
            {
                Console.WriteLine($"Sorry but {nameOfPerson()} doesn't have any favorite songs.");
            }
        }

    }
}
