using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Static
{
    public static class UserDatabase
    {

        // public static List<User> Users = new List<User>();

        //  static UserDatabase()                               // staticki konstruktor lista users je staticka i pripada samo klasi UserDatabase a ne instani klase.
        //   {                                                   // ovako se korisnici (users) dodaju samo jednom
        //     Users.Add(new User(1, "Marko", 33));
        //     Users.Add(new User(5, "Mirko", 44));
        //     Users.Add(new User(3, "Zeljko", 66));
        // }

        public static List<User> Users = new List<User>()

        {
            new User (1, "Marko", 33 ),
            new User(4, "Mirko", 44 ),
            new User(6, "Ivan", 66 ),
        };

        public static List<User> Search(int? id = null, string name = null, int? age = null)        // ovakav null omogucava da se u pozivu prosledi argument i filtrira samo po njemu
        {
            return Users.Where(user =>
                (!id.HasValue || user.Id == id.Value) &&
                (string.IsNullOrEmpty(name) || user.Name.Contains(name, System.StringComparison.OrdinalIgnoreCase)) &&   //  proverava da li sadrzi Name bez obzira na velika slova
                (!age.HasValue || user.Age == age.Value)
            ).ToList();
        }
    }
}
