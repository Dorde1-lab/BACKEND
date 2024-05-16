﻿using Class2_Advanced.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_Advanced
{
    public class Developer : Human
    {
        public List<string> ProgrammingLanguages { get; set; }
        public Role CurrentRole { get; set; }

        public Developer(string fullName, int age)
            : base(fullName, age)
        { }

        public override string GetInfo()
        {
            string role = "Junior";
            switch (CurrentRole)
            {
                case Role.Medior:
                    role = "Medior";
                    break;
                case Role.Senior:
                    role = "Senior";
                    break;
                case Role.Architect:
                    role = "Architect";
                    break;
                case Role.CTO:
                    role = "CTO";
                    break;
                default:
                    break;
            }

            return $"{FullName} - {Age} - Programming Languages: " +
                $"{string.Join(",", ProgrammingLanguages)} - Current Role  {role}";
        }
    }
}
