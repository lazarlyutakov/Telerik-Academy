﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        public override string Gender { get; protected set; }

        public Frog(string name, int age, string gender) : base (name, age, gender)
        {

        }

        public override void AnimalSound()
        {
            Console.WriteLine("Kva kva....");
        }
    }
}
