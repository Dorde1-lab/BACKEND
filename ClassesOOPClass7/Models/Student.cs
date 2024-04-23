using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7Task1.Models
{
    public class Student
    {

        public Student(string Name, string Academy, string Group)
        {
            this.Name = Name;
            this.Academy = Academy;
            this.Group = Group;
        }



        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }


    }
}
