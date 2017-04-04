﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private float grade;

        public float Grade
        {
            get { return this.grade; }
            private set { this.grade = value; }
        }

        public Student(string firstName, string lastName, float grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
