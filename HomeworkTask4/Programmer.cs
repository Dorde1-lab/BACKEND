using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask4
{
    internal class Programmer : Employee
    {

        private double rate;
        private int hoursSpent;

        public Programmer(string name, int id, double rate, int hoursSpent)
            : base(name, id)
        {
            this.rate = rate;
            this.hoursSpent = hoursSpent;
        }

        public override double CalculateSalary()
        {
            return rate * hoursSpent;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer Name: {Name}, ID: {Id}, Salary: {CalculateSalary()}");
        }
    }
}
