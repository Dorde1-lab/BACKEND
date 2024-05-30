using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Static
{
    public class Boat : Vehicle
    {

        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a boat and i do not have wheels.");
        }
    }
}
