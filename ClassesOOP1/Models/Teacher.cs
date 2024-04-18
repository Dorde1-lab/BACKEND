using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesOOP.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }

        public string[] LearningModules { get; set; }

        private string YearOfAward { get; set; };             // private (dostupan samo u ovoj klasi Teacher)...... dole primer zasto i kako moze postati public;


        public void SayHello()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName} and i am {Age} years old.");
        }







        // metodom mozemo private prebaciti na public;
        public void SetYearOfAward(string yearOfAward)
        {
            yearOfAward = yearOfAward;
        }
    }
}
