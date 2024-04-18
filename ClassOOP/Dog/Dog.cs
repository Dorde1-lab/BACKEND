using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOOP.Dog
{
    public class Dog
    {
        public string name  { get; set; };
        public string race { get; set; };
        public string color { get; set; };

        static void Eat()
        {
            Console.WriteLine($"The dog is now eating.");
        }

        static void Play()
        {
            Console.WriteLine($"The dog is now playing.");
        }

        static void ChaseTail()
        {
            Console.WriteLine($"The dog is now chasing its tail.");
        }

    }
}
