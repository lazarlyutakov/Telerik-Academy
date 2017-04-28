using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SchoolSystem.Enums;
using SchoolSystem.Contracts;

namespace SchoolSystem.Models
{
    public class Student : IStudent
    {
        private string firstName;
        private string lastName;                
        private Grade grade;
        private List<Mark> mark;


        public Student(string firstName, string lastName, Grade grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            Mark = new List<Mark>();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
           private set
            {
                if (value.Length < 2 || value.Length > 31 || !Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    throw new ArgumentOutOfRangeException("The first name must be between 1 and 31 symbols");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length < 2 || value.Length > 31 || !Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    throw new ArgumentOutOfRangeException("The last name must be between 1 and 31 symbols");
                }

                this.lastName = value;
            }
        }

        public Grade Grade { get; private set; }

        public List<Mark> Mark
        {
            get
            {
                return this.mark;
            }
            private set
            {
                if (value.Count > 20)
                {
                    throw new ArgumentOutOfRangeException("The maximum amount of grades is 20!");
                }

                this.mark = value;
            }
        }

        public string ListMarks()
        {
            var listOfMarks = this.mark.Select(m => $"{m.subject} => {m.value}").ToList();

            return string.Join("\n", listOfMarks);
        }
    }
}
