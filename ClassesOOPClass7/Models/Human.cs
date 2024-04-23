using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7Task1.Models
{
    public class Human
    {


            public Human(string FirsName, string LastName, int Age)
            {
                this.FirsName = FirsName;
                this.LastName = LastName;
                this.Age = Age;
            }


            public string FirsName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string GetPersonStats()
            {
                return $"Full name of the person is {FirsName} {LastName} and he/her is {Age} years old";
            }
        }

    }

