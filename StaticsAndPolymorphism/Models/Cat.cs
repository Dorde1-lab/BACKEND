﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticsAndPolymorphism.Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }

        public override void Eat()
        {
            //base.Eat();
            Console.WriteLine("I am a CAT and now I am eating");
        }
    }
}
