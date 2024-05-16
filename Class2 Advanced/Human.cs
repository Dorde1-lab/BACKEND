using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_Advanced
{
    public abstract class Human
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Human(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        public abstract string GetInfo();
        // public abstract string GetDescription();   -   Ovo mora biti implementirano i u izvedenim klasama. 
    }
}
