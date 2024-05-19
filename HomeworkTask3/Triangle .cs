using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask3
{
    class Triangle : Shape
    {
        public double side1;
        public double side2;
        public double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double CalculateArea()
        {

            double area = (side1 + side2 + side3) / 2;
            return Math.Sqrt(area * (area - side1) * (area - side2) * (area - side3));   // Math.Sqrt - vraca kvadratni koren 
        }

        public override double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
