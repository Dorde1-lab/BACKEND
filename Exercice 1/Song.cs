using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    public class Song
    {

        public string Title { get; set; }
        public int Length { get; set; }

        public GenreEnum Genre { get; set; }

        public Song( string title, int length, GenreEnum genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }



    }
}
