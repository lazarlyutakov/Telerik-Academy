﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class People
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public People(string name)
        {
            this.Name = name;
        }
    }
}
