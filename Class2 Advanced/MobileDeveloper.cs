using Class2_Advanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_Advanced
{
     internal class MobileDeveloper : Developer, IDeveloper
    {
        public MobileDeveloper(string fullName, int age) : base(fullName, age)
        {
        }

        public void Code()
        {
            throw new NotImplementedException();
        }

        public void Debug()
        {
            throw new NotImplementedException();
        }
    }
}
