using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    public class Person
    {

        private string _firstName;
        public string FirstName                               // full property 
        {
            get { return _firstName; }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Empty value");

                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Empty value");

                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Empty value");

                _firstName = value;
            }
        }

        public string LastName { get; set; }                       // out of property 

        //public void SetFirstName(string firstName)
        //{
        //    if (string.IsNullOrEmpty(firstName))
        //        throw new ArgumentException("Empty value");

        //    // ...

        //    _firstName = firstName;
        //}

        //public string GetFirstName()
        //{
        //    return _firstName;
        //}
    }
}
