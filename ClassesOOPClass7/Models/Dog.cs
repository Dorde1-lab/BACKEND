using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOOP.Dog
{
    /*

        public class Dog(string FirstName, string LastName, int Age)
        {
            public string FirstName { get; set; } = FirstName;
            public string LastName { get; set; } = LastName;
            public int Age { get; set; } = Age;

            public string GetPersonStats()
            {
                return $"Full name of this person is {FirstName} {LastName} and he is {Age} years old.";
            }
        }
        */




    // ................... Drugaciji nacin


    public class Dog
    {

        public Dog(string Name, string race, string color)
        {
            this.Name = Name;
            this.Race = race;
            this.Color = color;

        }



        public string Name { get; set; }
        public string Race { get; set; }

        public string Color { get; set; }

        public string Eat()
        {
            return $"The dog name {this.Name} is now eating";
        }

        public string Play()
        {
            return $"The dog name {this.Name} is now eating";
        }

        public string ChaseTail()
        {
            return $"The dog name {this.Name} is now eating";
        }
    }


}
