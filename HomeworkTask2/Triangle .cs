using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask2
{
    public class Triangle : IShape
    {


        private double length;
        private double height;

        public Triangle(double length, double height)
        {
            this.length = length;
            this.height = height;
        }
        public double GetArea()
        {
            return 0.5 * length * height;
        }

    }
}
