﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTask2
{
    public class Circle : IShape
    {
        private double radius;

        public Circle (double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius;
        }
    }
}
