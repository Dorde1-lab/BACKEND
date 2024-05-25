using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask4
{
    public  class Manager : Employee
    {

        private double salary;
        private double bonus;

        public Manager(string name, int id, double salary, double bonus)
            : base(name, id)
        {
            this.salary = salary;
            this.bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return salary + bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager Name: {Name}, ID: {Id}, Salary: {CalculateSalary()}");
        }

    }
}
