using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SchoolSystem.Enums;
using SchoolSystem.Contracts;

namespace SchoolSystem.Models
{
    internal class Student : IStudent
    {
        private string firstName;
        private string lastName;
        private Grade grade;
        private List<Mark> mark;


        public Student(string firstName, string lastName, Grade grade)
        {
            if (firstName.Length < 2 || firstName.Length > 31 || !Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentOutOfRangeException("The first name must be between 2 and 31 symbols");
            }
            else
            {
                this.firstName = firstName;
            }

            if (lastName.Length < 2 || lastName.Length > 31 || !Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentOutOfRangeException("The last name must be between 2 and 31 symbols");
            }
            else
            {
                this.lastName = lastName;
            }

            this.grade = grade;

            if (mark.Count > 20)
            {
                throw new ArgumentOutOfRangeException("The maximum amount of marks is 20!");
            }
            else
            {
                mark = new List<Mark>();
            }

        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public Grade Grade { get; }

        public List<Mark> Mark
        {
            get
            {
                return this.mark;
            }
        }

        public string ListMarks()
        {
            var listOfMarks = this.mark.Select(m => $"{m.Subject} => {m.Value}").ToList();

            return string.Join("\n", listOfMarks);
        }
    }
}
