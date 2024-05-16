using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask2
{
    public class Rectangle : IShape
    {

        private double width;
        private double height;
        public double result;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            result = width * height;
            return result;
        }
    }
}
