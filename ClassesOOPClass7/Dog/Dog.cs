using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOOP.Dog
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        // Konstruktor
        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }


        public string Eat()
        {
            return $"The dog named {Name} is now eating.";
        }

        public string Play()
        {
            return $"The dog named {Name} is now playing.";
        }

        public string ChaseTail()
        {
            return $"The dog named {Name} is now chasing.";
        }

    }
}